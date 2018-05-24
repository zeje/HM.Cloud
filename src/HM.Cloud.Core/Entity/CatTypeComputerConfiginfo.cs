
using System;
namespace HM.Cloud
{
    /// <summary>
    /// 猫类型的主机与标准配置关联
    /// </summary>
    public class CatTypeComputerConfiginfo : EntityBase
    {
        /// <summary>
        /// 猫类型的编号
        /// </summary>
        public string CatTypeCode { get; set; }
        /// <summary>
        /// 主机编号
        /// </summary>
        public string ComputerCode { get; set; }
        /// <summary>
        /// 标准配置编号
        /// </summary>
        public string ConfigCode { get; set; }
        /// <summary>
        /// 标准配置名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 模板内容（xml）
        /// </summary>
        public string Template { get; set; }
    }
}