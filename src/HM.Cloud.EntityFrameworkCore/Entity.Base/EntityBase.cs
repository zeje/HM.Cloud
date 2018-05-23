using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace HM.Cloud
{
    /// <summary>
    /// 实体基类
    /// </summary>
    public class EntityBase : Entity<long>, IHasCreationTime, IHasModificationTime
    {
        /// <summary>
        /// 
        /// </summary>
        public EntityBase()
        {
            CreationTime = DateTime.Now;
            LastModificationTime = DateTime.Now;
        }
        /// <summary>
        /// 创建人
        /// </summary>
        public virtual long CreatorUserId { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public virtual long LastModifierUserId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime CreationTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public virtual DateTime? LastModificationTime { get; set; }
    }
}
