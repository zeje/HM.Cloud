using System;
namespace HM.Cloud
{
    /// <summary>
    /// 猫与主机关联
    /// </summary>
    public class CatComputer : EntityBase
    {
        /// <summary>
        /// 猫编号
        /// </summary>
        public int CatCode { get; set; }
        /// <summary>
        /// 主机编号
        /// </summary>
        public string ComputerCode { get; set; }
        /// <summary>
        /// 主机名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// IP
        /// </summary>
        public string Ip { get; set; }
        /// <summary>
        /// 端口
        /// </summary>
        public int Port { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
    }
}