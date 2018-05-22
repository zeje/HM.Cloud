using System;
using System.ComponentModel.DataAnnotations;

namespace HM.Cloud.EntityFrameworkCore
{
    /// <summary>
    /// 菜单
    /// </summary>
    public class SysMenu : EntityBase
    {
        public SysMenu()
        {
            OrderNo = 0;
        }
        /// <summary>
        /// 父ID
        /// </summary>
        public long? ParentId { get; set; }
        /// <summary>
        /// 菜单名称
        /// </summary>
        [StringLength(128)]
        public string Name { get; set; }
        /// <summary>
        /// 访问路径
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(256)]
        public string Url { get; set; }
        /// <summary>
        /// 图标样式
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(64)]
        public string IconClass { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int OrderNo { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(512)]
        public string Remarks { get; set; }
    }
}