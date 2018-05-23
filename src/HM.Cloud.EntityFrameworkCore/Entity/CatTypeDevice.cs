
using System;
namespace HM.Cloud
{
    /// 猫型号与设备关联表
    public class CatTypeDevice : EntityBase
    {
        /// <summary>
        /// 猫型号的编号
        /// </summary>
        public string CatTypeCode { get; set; }
        /// <summary>
        /// 设备编号
        /// </summary>
        public string DeviceCode { get; set; }
        /// <summary>
        /// 设备名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 是否信号设备：1是；0否
        /// </summary>
        public byte SignalDevice { get; set; }
        /// <summary>
        /// 是否网络设备：1是；0否
        /// </summary>
        public byte NetDevice { get; set; }
        /// <summary>
        /// 默认IP
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// 默认端口
        /// </summary>
        public int Port { get; set; }
        /// <summary>
        /// 默认用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 默认密码
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// 状态：1正常；0停用
        /// </summary>
        public byte Status { get; set; }
    }
}