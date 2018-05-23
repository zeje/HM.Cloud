using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM.Cloud
{
    /// <summary>
    /// 表格
    /// </summary>
    public class Grid : Permission
    {
        /// <summary>
        /// 表格字段集合
        /// </summary>
        public virtual ICollection<GridField> GridField { get; set; }
    }
}
