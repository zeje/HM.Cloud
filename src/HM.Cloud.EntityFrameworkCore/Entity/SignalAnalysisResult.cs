using System;
using System.ComponentModel.DataAnnotations;

namespace HM.Cloud.EntityFrameworkCore
{
    /// <summary>
    /// 用户状态
    /// </summary>
    public enum AlarmTypeStatus
    {
        异常 = 0,
        正常 = 1
    }

    public enum AlarmTypeEnum
    {

    }

    /// <summary>
    /// 信号分析结果
    /// </summary>
    public class SignalAnalysisResult : EntityBase
    {
        [Required]
        [StringLength(32)]
        /// <summary>
        /// 项目编号
        /// </summary>
        public string ProjectCode { get; set; }
        /// <summary>
        /// 黑猫编号
        /// </summary>
        public int CatCode { get; set; }
        /// <summary>
        /// 报警监控类型
        /// </summary>
        public AlarmTypeEnum AlarmType { get; set; }
        /// <summary>
        /// 报警节点状态
        /// </summary>
        public AlarmTypeStatus AlarmTypeStatus { get; set; }
        /// <summary>
        /// 报警消息
        /// </summary>
        public string AlarmInfo { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifyTime { get; set; }
    }
}