// File:    SysRole.cs
// Author:  caizz
// Created: 2018年5月22日 15:16:06
// Purpose: Definition of Class SysRole
using System;
using System.ComponentModel.DataAnnotations;

namespace HM.Cloud.EntityFrameworkCore
{
    /// <summary>
    /// 角色
    /// </summary>
    public enum RoleStatus
    {
        停用 = 0,
        启用 = 1
    }
    /// <summary>
    /// 角色
    /// </summary>
    public class SysRole : EntityBase
    {
        /// <summary>
        /// 角色名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(512)]
        public string Remarks { get; set; }
        /// <summary>
        /// 状态：0停用；1启用；
        /// </summary>
        public RoleStatus Status { get; set; }
    }
}