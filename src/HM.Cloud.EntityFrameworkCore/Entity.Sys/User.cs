using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
namespace HM.Cloud
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
    /// 管理人员--实体类
    /// </summary>
    public class User : EntityBase
    {
        public User()
        {
            LoginCount = 0;
        }
        /// <summary>
        /// 账号
        /// </summary>
        [Required]
        [StringLength(128)]
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        [StringLength(128)]
        public string PassWord { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(128)]
        public string TrueName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public bool? Sex { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime? Birthday { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(11)]
        public string Phone { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(128)]
        public string Email { get; set; }
        /// <summary>
        /// 身份证
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(18)]
        public string IDCard { get; set; }
        /// <summary>
        /// 用户状态
        /// </summary>
        public UserStatus UserStatus { get; set; }
        /// <summary>
        /// 登录Ip
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(64)]
        public string LoginIp { get; set; }
        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime? LoginTime { get; set; }
        /// <summary>
        /// 登录次数
        /// </summary>
        public int LoginCount { get; set; }
        /// <summary>
        /// 登陆失败累计
        /// </summary>
        public int? LoginFailedTimes { get; set; }
        /// <summary>
        /// 注册Ip
        /// </summary>
        public string RegisterIp { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime RegisterTime { get; set; }
        /// <summary>
        /// 密码设置时间，用于提醒检测密码修改周期
        /// </summary>
        public DateTime PasswordSetTime { get; set; }
        /// <summary>
        /// 所属部门Id
        /// </summary>
        public ICollection<Guid> DepartmentId { get; set; }
        public List<UserRole> ManagerRoles { get; set; }
    }
}
