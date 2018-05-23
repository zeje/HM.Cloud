
using System;
namespace HM.Cloud
{
    /// <summary>
    /// 信号分析结果迭代
    /// <![CDATA[
    /// （原记录未解决则更新，已解决则新增）
    /// ]]>
    /// </summary>
    public class SignalAnalysisIterate : EntityBase
    {
        /// <summary>
        /// 项目编号
        /// </summary>
        public string ProjectCode { get; set; }
        /// <summary>
        /// 猫编号
        /// </summary>
        public int CatCode { get; set; }
        /// <summary>
        /// 信号类型(1、abnormal；2、gpio；3、ping)
        /// </summary>
        public byte SignalType { get; set; }
        /// <summary>
        /// 报警监控类型
        /// </summary>
        public byte AlarmType { get; set; }
        /// <summary>
        /// 报警名称
        /// </summary>
        public string AlarmName { get; set; }
        /// <summary>
        /// 报警次数
        /// </summary>
        public int AlarmTimes { get; set; }
        /// <summary>
        /// 报警级别
        /// </summary>
        public int AlarmLevel { get; set; }
        /// <summary>
        /// 报警消息
        /// </summary>
        public string AlarmInfo { get; set; }
        /// <summary>
        /// 年
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// 月
        /// </summary>
        public int Month { get; set; }
        /// <summary>
        /// 日
        /// </summary>
        public int Day { get; set; }
        /// <summary>
        /// 时
        /// </summary>
        public int Hour { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 信号产生时间
        /// </summary>
        public DateTime SignalTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifyTime { get; set; }
        /// <summary>
        /// 恢复时间
        /// </summary>
        public DateTime RecoverTime { get; set; }
        /// <summary>
        /// 恢复标志
        /// </summary>
        public byte RecoverFlag { get; set; }
        /// <summary>
        /// 恢复消息
        /// </summary>
        public string RecoverInfo { get; set; }
    }
}