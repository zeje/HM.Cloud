using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HM.Cloud
{
    /// <summary>
    /// 表格字段信息
    /// </summary>
    public class GridField : Permission
    {
        public GridField()
        {

        }
        /// <summary>
        /// 下级子菜单
        /// </summary>
        public ICollection<GridField> SubGridFields { get; set; }
    }
}
