
using System;
using System.ComponentModel.DataAnnotations;

namespace HM.Cloud.EntityFrameworkCore
{
    /// <summary>
    /// 用户状态
    /// </summary>
    public enum UserStatus
    {
        停用 = 0,
        启用 = 1
    }
    /// <summary>
    /// 用户
    /// </summary>
    public class SysUser : EntityBase
    {
        /// <summary>
        /// 登陆账号
        /// </summary>
        [Required]
        [StringLength(128)]
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        [StringLength(256)]
        public string Password { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(128)]
        public string Name { get; set; }
        /// <summary>
        /// 角色ID
        /// </summary>
        public long? RoleId { get; set; }
        /// <summary>
        /// 所属大区ID
        /// </summary>
        public long? RegionId { get; set; }
        /// <summary>
        /// 所属城市ID
        /// </summary>
        public long? CityId { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(11)]
        public string Phone { get; set; }
        /// <summary>
        /// 邮箱地址
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(128)]
        public string Email { get; set; }
        /// <summary>
        /// 状态：1正常；0停用
        /// </summary>
        public UserStatus Status { get; set; }
        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime? LoginDate { get; set; }
        /// <summary>
        /// 登陆失败累计
        /// </summary>
        public int? LoginFailedTimes { get; set; }
    }
}