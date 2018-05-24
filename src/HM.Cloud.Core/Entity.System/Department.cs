using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace HM.Cloud
{
    /// <summary>
    /// 部门
    /// </summary>
    public class Department : EntitySysBase
    {
        public Department()
        {
            Sort = 0;
        }
        /// <summary>
        /// 父部门Id
        /// </summary>
        public Guid ParentId { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(64)]
        public string Name { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(512)]
        public string Description { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
        /// <summary>
        /// 下级部门
        /// </summary>
        public ICollection<Department> SubDepartments { get; set; }
        /// <summary>
        /// 部门角色
        /// </summary>
        public ICollection<DepartmentRole> DepartmentRoles { get; set; }
    }
}
