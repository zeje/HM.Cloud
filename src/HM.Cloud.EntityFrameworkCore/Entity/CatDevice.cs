// File:    CatDevice.cs
// Author:  caizz
// Created: 2018年5月22日 15:16:06
// Purpose: Definition of Class CatDevice
using System;
namespace HM.Cloud
{
    /// <summary>
    /// 猫与设备关联
    /// </summary>
    public class CatDevice : EntityBase
    {
        /// <summary>
        /// 猫编号
        /// </summary>
        public int CatCode { get; set; }
        /// <summary>
        /// 设备编号
        /// </summary>
        public string DeviceCode { get; set; }
        /// <summary>
        /// 设备名称
        /// </summary>
        public string Name { get; set; }
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
    }
}