using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace HM.Cloud
{
    public class DepartmentRole : EntityBase
    {
        /// <summary>
        /// 部门Id
        /// </summary>
        public long DepartmentId { get; set; }
        /// <summary>
        /// 角色Id
        /// </summary>
        public long RoleId { get; set; }
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
