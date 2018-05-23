
using System;
namespace HM.Cloud
{
    /// <summary>
    /// 人脸进出详情
    /// </summary>
    public class CatFaceEntranceDetail : EntityBase
    {
        /// <summary>
        /// 
        /// </summary>
        public long ID { get; set; }
        /// <summary>
        /// 项目编码
        /// </summary>
        public string ProjectCode { get; set; }
        /// <summary>
        /// 猫编号
        /// </summary>
        public int CatCode { get; set; }
        /// <summary>
        /// 人员名称
        /// </summary>
        public string PersonName { get; set; }
        /// <summary>
        /// 房号
        /// </summary>
        public string RoomNo { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public string Age { get; set; }
        /// <summary>
        /// 人脸编号
        /// </summary>
        public string FaceID { get; set; }
        /// <summary>
        /// 人员编号
        /// </summary>
        public string PersonID { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}