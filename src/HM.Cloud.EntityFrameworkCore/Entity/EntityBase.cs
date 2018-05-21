using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace HM.Cloud.EntityFrameworkCore
{
    /// <summary>
    /// 实体基类
    /// </summary>
    public class EntityBase
    {
        /// <summary>
        /// 
        /// </summary>
        public EntityBase()
        {
            AddTime = DateTime.Now;
            UpdateTime = DateTime.Now;
        }
        [Key]
        public virtual int Id { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [StringLength(EntityConst.AccountNameLength)]
        public virtual string AddUser { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        [StringLength(EntityConst.AccountNameLength)]
        public virtual string UpdateUser { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime AddTime { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public virtual DateTime UpdateTime { get; set; }
    }
}
