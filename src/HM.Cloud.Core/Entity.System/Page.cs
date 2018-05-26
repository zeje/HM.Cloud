using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HM.Cloud
{
    /// <summary>
    /// 页面
    /// </summary>
    public class Page : Permission
    {
        public Page()
        {
            IsVisible = true;
        }
        /// <summary>
        /// 图片地址
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(128)]
        public string Icon { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(128)]
        public string Url { get; set; }
        /// <summary>
        /// 是否可见
        /// </summary>
        public bool IsVisible { get; set; }
        /// <summary>
        /// 子页面
        /// </summary>
        public ICollection<Page> SubPages { get; set; }

        public ICollection<Grid> Grids { get; set; }
    }
}
