http://www.cnblogs.com/vipyoumay/p/7525478.html

- [ASP.NET Core Web服务器 Kestrel和Http.sys 特性详解](#aspnet-core-web服务器-kestrel和httpsys-特性详解)
- [1.1. 名词解释](#11-名词解释)
- [1.2. Kestrel基本工作原理](#12-kestrel基本工作原理)
- [1.2.1. Kestrel的基本架构](#121-kestrel的基本架构)
- [1.2.2. Kestrel的工作原理](#122-kestrel的工作原理)
- [1.2.2.1. 处理Request和Response](#1221-处理request和response)
- [1.2.2.2. 内存池读写](#1222-内存池读写)
- [1.2.2.3. Libuv线程和托管线程通信](#1223-libuv线程和托管线程通信)

- [1.3. Http.sys基本工作原理](#13-httpsys基本工作原理)
- [1.3.1. Http.sys基本构成](#131-httpsys基本构成)
- [1.3.2. Http.sys工作原理](#132-httpsys工作原理)
- [1.3.3. 总结](#133-总结)

## 1.1. 名词解释

**内核态:** CPU可以访问内存所有数据, 包括外围设备, 例如硬盘, 网卡. CPU也可以将自己从一个程序切换到另一个程序。

**用户态:** 只能受限的访问内存, 且不允许访问外围设备. 占用CPU的能力被剥夺, CPU资源可以被其他程序获取。

## 1.2. Kestrel基本工作原理

Kestrel是进程内服务器，以一个包形式提供，自身不能单独运行，必须HOST在一个.NET的WEB应用程序中。它内部封装了对libuv的调用，但不是libuv库简单的封装库。Kestrel是个精简的，高效的Http Server。

### 1.2.1. Kestrel的基本架构

Kestrel遵循以下架构原则：

- libuv中使用单线程的事件循环模型。
- Kestrel支持多事件循环以支持更多的I/O。
- Kestrel仅在libuv的事件循环中做I/O工作。
- 所有非I/O工作，包括HTTP解析，请求帧处理等等都在标准的托管线程中进行。
- 更少的系统调用。

对应的架构图如下：

![2017-09-13-23-07-16](http://qiniu.xdpie.com/2017-09-13-23-07-16.png?imageView2/2/w/700&amp;_=5603928)

- 
Libuv

作为I/O底层，屏蔽各系统底层实现差异，为windows下，通过IOCP实现异步；linux下通过epoll实现异步。提供一个主程序和主循环。

- 
I/O事件队列

对应Libuv的工作队列，为了利用现代服务器的多核处理器，适当的队列数量将提高更大的I/O吞吐能力。Kestrel默认为每两个CPU核心设置一个I/O事件队列，但至少有一个I/O事件队列。每个队列对应一个托管线程，该线程不属于线程池。用户可以设置队列个数，通过设置KestrelServerOptions.ThreadCount即可，最多设置16个。

- 
Kestrel线程

事件队列对应的托管线程，主要控制读取事件的循环机制：每次事件循环处理8个事件，然后等待下一次循环。

- 
非托管内存池

这是在.net运行环境分配的非托管内存池，申请的比较大块的堆内存，仅在首次请求或者池剩余空间不足时分配，后续请求可以复用，不受GC管理。内存被分为n片，每片大小是128K，每页大小4k,管理内存页的数据结构采用链表方式。以获取大块连续空间的方式增长。遵循读完后立即释放的处理原则。

- 
TCP监听器

这个监听器不同于套接字的监听器，而是Libuv的Socket类型的连接事件监听器。监听TCP连接事件,对每一个TCP请求产生一个连接对象。连接对象包括暂停，继续，终止。

- 
连接管理

负责异步结束连接对象。

- 
HTTP协议模块

该模块包括HTTP帧的创建工厂，工厂在监听器监听到一个连接时产生一个HTTP帧。一个HTTP帧处理一次HTTP请求和返回。

更为详细的结构视图如下：

![2017-09-13-23-23-55](http://qiniu.xdpie.com/2017-09-13-23-23-55.png)

### 1.2.2. Kestrel的工作原理

#### 1.2.2.1. 处理Request和Response

![2017-09-14-21-21-30](http://qiniu.xdpie.com/2017-09-14-21-21-30.png)

按照请求流转方向会有以下处理过程：

**1. 请求进入libuv**

将请求事件放入事件队列，随后的事件循环中，监听器回调函数执行。

**2. 监听器创建连接**

根据请求信息创建一个连接对象，此时Http帧工厂被调用，产生一个Http帧对象；用于读取Request的SocketInput、用于返回Response的SocketOutput对象被创建，二者会被Http帧使用。

**3. 连接管理监控连接**

连接管理器跟踪连接的状态，收集待关闭连接，然后异步关闭。

**4. Http帧处理**

一个Http负责构建Http上下文的Request对象和Response对象。读取Request数据和返回Response数据都要经过内存池。高效的内存读写和与和Libuv的读写事件协调，确保Request数据到达就能读到内存池，到达内存池就能及时被读；Response数据写入内存池就能被套接字及时发出去，体现了Kestreld强大的异步处理能力。

#### 1.2.2.2. 内存池读写

读取内存池数据时可读取后续到达的数据，不需要重新等待事件，此时对应读取Request数据情形：

![2017-09-14-23-42-10](http://qiniu.xdpie.com/2017-09-14-23-42-10.png)

写数据到内存池时，libuv连续读出并发送数据，也不需要重新等待时间，此时对应发送Response数据情形：

![2017-09-14-23-42-58](http://qiniu.xdpie.com/2017-09-14-23-42-58.png)

#### 1.2.2.3. Libuv线程和托管线程通信

二者的通信机制保证Libuv线程永远不会被阻塞：比如libuv线程在通知事件时会很小心尝试获取队线程私有锁，如果成功获取就这在事件队列线程上异步处理，否则这一通信过程在线程池里重复执行直到成功，如图：

![2017-09-14-23-28-33](http://qiniu.xdpie.com/2017-09-14-23-28-33.png)

## 1.3. Http.sys基本工作原理

### 1.3.1. Http.sys基本构成

![2017-09-10-12-25-14](http://qiniu.xdpie.com/2017-09-10-12-25-14.png?imageView2/2/w/700&amp;_=5603928)

**1. 监听器**

监听TCP请求，允许端口共享。TCP携带的HTTP报文会被Http Parser解析，名称映射首先会根据url确定对应的web app，然后把请求放入该app的消息队列中。

**2. 消息队列**

Http.sys给每个注册的web app一个消息队列。

**3. 响应缓存**

请求的静态资源和GET请求会缓存起来一段时间，如果请求url能匹配这直接返回缓存数据。

**4. 响应模块**

将数据返回给用户代理，如果返回的是可以缓存的资源，则会放入响应缓存中。

### 1.3.2. Http.sys工作原理

下图表示在ASP.NET Core应用中接受一个http请求到返回数据的过程：

![2017-09-10-11-29-05](http://qiniu.xdpie.com/2017-09-10-11-29-05.png?imageView2/2/w/700&amp;_=5603928)

1. 
这里的TCPIP.sys也是windows内核驱动，提供了TCPIP协议栈。

2. 
Http.sys的处理如在“基本构成”做所述。

3. 
ASP.NET Core应用程序里面HttpSys模块代表了Http.sys，它与应用程序代码交流，交流的载体是HTTP上下文。

### 1.3.3. 总结

Kestrel服务器运行在Asp.net core应用程序中，能高效的处理网络请求，且跨平台。Http.sys运行在内核态中，极大减少了系统调用次数，运行效率很高；自带生存环境的安全，鲁棒性等特点；它也可以作为反向代理，因此它的功能更加强大，主要问题是只能运行在windows下。Kestrel应用在生产环境中需要运行在代理服务器后面，以获取安全性，负载均衡等能力。
功能Http.sysKerstrel平台支持WindowsWindows/Linux/Mac静态文件YesYesHTTP访问日志YesNo端口共享/多应用程序YesNoSSL证书YesInternal*Windows 授权YesNo过滤请求&限制YesNoIP&域名约束YesNoHTTP重定向规则YesNoWebSocket 协议YesMiddleware缓存ResponseYesNo压缩YesYesFTP服务器YesNo运行态内核态用户态
* Internal：https通信仅仅工作在反向代理服务器后面与ASP.NET程序之间，如果要想外暴露https服务这需要用到反向代理,比如IIS,nginx,apached。

> 参考文章

[http://www.cnblogs.com/yxmx/articles/1652128.html](http://www.cnblogs.com/yxmx/articles/1652128.html)

[http://www.cnblogs.com/arbin98/archive/2010/09/03/1816847.html](http://www.cnblogs.com/arbin98/archive/2010/09/03/1816847.html)

[https://stackify.com/kestrel-web-server-asp-net-core-kestrel-vs-iis/](https://stackify.com/kestrel-web-server-asp-net-core-kestrel-vs-iis/)

> 作者：帅虫哥 出处： [http://www.cnblogs.com/vipyoumay/p/7525478.html](http://www.cnblogs.com/vipyoumay/p/7525478.html)