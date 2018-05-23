using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM.Cloud
{
    public class RoleGridField : EntitySysBase
    {
        /// <summary>
        /// 角色Id
        /// </summary>
        public Guid RoleId { get; set; }
        /// <summary>
        /// 页面Id
        /// </summary>
        public Guid PageId { get; set; }
        /// <summary>
        /// 角色
        /// </summary>
        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
        /// <summary>
        /// 表格字段
        /// </summary>
        [ForeignKey("GridFieldId")]
        public virtual GridField GridField { get; set; }
    }
}
