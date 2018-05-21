using System;
using System.Collections.Generic;
using System.Text;

namespace HM.Cloud.EntityFrameworkCore
{
    /// <summary>
    /// 软件版本
    /// </summary>
    public partial class SoftVersion : EntityBase
    {
        /// <summary>
        /// 软件名称
        /// </summary>
        public string SoftName { get; set; }
        /// <summary>
        /// 版本
        /// </summary>
        public string Version { get; set; }
        /// <summary>
        /// 更新文件下载地址
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// 变更日志
        /// </summary>
        public string Changelog { get; set; }
        /// <summary>
        /// 是否强制
        /// </summary>
        public bool Mandatory { get; set; }
    }
}
