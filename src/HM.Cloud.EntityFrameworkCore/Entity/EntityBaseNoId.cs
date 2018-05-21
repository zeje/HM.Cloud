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
    public class EntityBaseNoId
    {
        public EntityBaseNoId()
        {
            CreateTime = DateTime.Now;
            ModifyTime = DateTime.Now;
        }
        /// <summary>
        /// 创建人
        /// </summary>
        [StringLength(Account.AccountNameLength)]
        public virtual string CreateUser { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        [StringLength(Account.AccountNameLength)]
        public virtual string UpdateUser { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime CreateTime { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public virtual DateTime UpdateTime { get; set; }
    }
}
