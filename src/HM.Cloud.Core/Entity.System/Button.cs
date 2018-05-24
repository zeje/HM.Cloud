using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
namespace HM.Cloud
{
    /// <summary>
    /// 按钮
    /// </summary>
    public class Button : Permission
    {
        /// <summary>
        /// 样式名称
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(64)]
        public string IconClass { get; set; }
    }
}
