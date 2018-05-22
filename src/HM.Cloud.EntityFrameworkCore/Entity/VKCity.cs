// File:    VKCity.cs
// Author:  caizz
// Created: 2018年5月22日 15:16:06
// Purpose: Definition of Class VKCity
using System;
namespace HM.Cloud.EntityFrameworkCore
{
    /// 城市表
    public class VKCity : EntityBase
    {
        /// <summary>
        /// 所属大区Id
        /// </summary>
        public string RegionId { get; set; }
        /// <summary>
        /// 编号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 城市名称
        /// </summary>
        public string Name { get; set; }
    }
}