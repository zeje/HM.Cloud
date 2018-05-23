using System;
namespace HM.Cloud
{
    /// <summary>
    /// 猫与报警节点关联表
    /// </summary>
    public class CatAlarmNode : EntityBase
    {
        /// <summary>
        /// 猫编号
        /// </summary>
        public int CatCode { get; set; }
        /// <summary>
        /// 项目编号
        /// </summary>
        public string ProjectCode { get; set; }
        /// <summary>
        /// 报警节点编号
        /// </summary>
        public string AlarmNodeCode { get; set; }
        /// <summary>
        /// 节点名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 报警类型
        /// </summary>
        public string AlarmType { get; set; }
        /// <summary>
        /// 信号规则配置（json）
        /// </summary>
        public string Rule { get; set; }
        /// <summary>
        /// 节点呈现位置信息（多属性）
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        /// 排序序号
        /// </summary>
        public int OrderNo { get; set; }
    }
}