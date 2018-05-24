using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace HM.Cloud
{
    public class DepartmentRole : EntitySysBase
    {
        /// <summary>
        /// 部门Id
        /// </summary>
        public Guid DepartmentId { get; set; }
        /// <summary>
        /// 角色Id
        /// </summary>
        public Guid RoleId { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
        [ForeignKey("DepartmentId")]
        public virtual Department Department { set; get; }
        /// <summary>
        /// 角色
        /// </summary>
        [ForeignKey("RoleId")]
        public virtual Role Role { set; get; }
    }
}
