// File:    VKProject.cs
// Author:  caizz
// Created: 2018年5月22日 15:16:06
// Purpose: Definition of Class VKProject
using System;
namespace HM.Cloud
{
    /// <summary>
    ///  项目
    /// </summary>
    public class VKProject : EntityBase
    {
        /// <summary>
        /// 项目编码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 所属大区ID
        /// </summary>
        public string RegionId { get; set; }
        /// <summary>
        /// 所属城市ID
        /// </summary>
        public string CityId { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        public long? Longitude { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public long? Latitude { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }
    }
}