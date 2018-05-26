﻿using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HM.Cloud
{
    /// <summary>
    /// 权限类别
    /// </summary>
    public enum PermissionType
    {
        Default = 0,
        Page = 1,
        Button = 2,
        Grid = 3,
        GridField = 4
    }
    /// <summary>
    /// 权限
    /// </summary>
    public class Permission : EntitySysBase, IHasDeletionTime, ISoftDelete
    {
        public Permission()
        {
            IsDeleted = false;
            Sort = 0;
        }
        /// <summary>
        /// 权限类别
        /// </summary>
        public PermissionType PermissionType { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(512)]
        public string Description { get; set; }
        /// <summary>
        /// 父Id
        /// </summary>
        public Guid ParentId { get; set; }
        /// <summary>
        /// 序号(同级排序)
        /// </summary>
        public int Sort { get; set; }
        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 删除者
        /// </summary>
        public Guid? DeleterUserId { get; set; }
        /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime? DeletionTime { get; set; }
        /// <summary>
        /// 子权限
        /// </summary>
        public ICollection<Permission> SubPermissions { get; set; }
    }
}
