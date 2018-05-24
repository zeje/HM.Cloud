
using System;
namespace HM.Cloud
{
    /// <summary>
    /// 大区
    /// </summary>
    public class VKRegion : EntityBase
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        public long? Longitude { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public long? Latitude { get; set; }
    }
}