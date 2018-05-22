
using System;
namespace HM.Cloud.EntityFrameworkCore
{
    /// <summary>
    /// 角色菜单权限
    /// </summary>
    public class SysRoleMenu : EntityBase
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        public long RoleId { get; set; }
        /// <summary>
        /// 菜单ID
        /// </summary>
        public long MenuId { get; set; }
    }
}