using System;
namespace HM.Cloud
{
    /// <summary>
    /// 猫型号
    /// </summary>
    public class CatType : EntityBase
    {
        /// <summary>
        /// 编号
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 猫型号图片路径
        /// </summary>
        public string PicPath { get; set; }
        /// <summary>
        /// 图片宽度
        /// </summary>
        public int PicWidth { get; set; }
        /// <summary>
        /// 图片高度
        /// </summary>
        public int PicHeight { get; set; }
        /// <summary>
        /// 状态：1正常；0停用
        /// </summary>
        public byte Status { get; set; }
    }
}