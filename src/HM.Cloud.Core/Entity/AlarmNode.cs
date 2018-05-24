using System;
namespace HM.Cloud
{
    /// <summary>
    /// 报警节点表
    /// </summary>
    public class AlarmNode : EntityBase
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 节点名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 报警类型
        /// </summary>
        public int AlarmType { get; set; }
        /// <summary>
        /// 信号规则配置（json）
        /// </summary>
        public string Rule { get; set; }
        /// <summary>
        /// 节点呈现位置信息（多属性）
        /// </summary>
        public string Position { get; set; }
    }
}