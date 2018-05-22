// File:    Cat.cs
// Author:  caizz
// Created: 2018年5月22日 15:16:06
// Purpose: Definition of Class Cat
using System;
namespace HM.Cloud.EntityFrameworkCore
{
    /// <summary>
    /// 猫
    /// </summary>
    public class Cat : EntityBase
    {
        /// <summary>
        /// 猫编号
        /// </summary>
        public int CatCode { get; set; }
        /// <summary>
        /// 位置
        /// </summary>
        public string Position { get; set; }
        /// <summary>
        /// 所属大区ID
        /// </summary>
        public string RegionId { get; set; }
        /// <summary>
        /// 所属城市ID
        /// </summary>
        public string CityId { get; set; }
        /// <summary>
        /// 项目编号
        /// </summary>
        public string ProjectCode { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string ProjectName { get; set; }
        /// <summary>
        /// 猫型号的编号
        /// </summary>
        public string CatTypeCode { get; set; }
        /// <summary>
        /// 经度
        /// </summary>
        public long? Longitude { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public long? Latitude { get; set; }
        /// <summary>
        /// 状态：1正常；0停用
        /// </summary>
        public byte Status { get; set; }
    }
}