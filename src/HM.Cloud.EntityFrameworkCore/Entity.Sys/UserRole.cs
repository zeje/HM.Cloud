using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace HM.Cloud
{
    /// <summary>
    /// 管理人员角色--实体类
    /// </summary>
    public class UserRole
    {
        /// <summary>
        /// 管理人员Id
        /// </summary>
        public long ManagerId { get; set; }
        /// <summary>
        /// 角色Id
        /// </summary>
        public long RoleId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public User Manager { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Role Role { get; set; }
    }
}
