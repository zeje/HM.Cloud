using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;

namespace HM.Cloud
{
    [AutoMapFrom(typeof(User))]
    public class UserListDto : EntityDto, IHasCreationTime
    {
        /// <summary>
        /// 账号
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string PassWord { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
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
        public string Phone { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 身份证
        /// </summary>
        public string IDCard { get; set; }
        /// <summary>
        /// 用户状态
        /// </summary>
        public UserStatus UserStatus { get; set; }
        /// <summary>
        /// 登录Ip
        /// </summary>
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
        /// 创建人
        /// </summary>
        public virtual Guid CreatorUserId { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        public virtual Guid LastModifierUserId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime CreationTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public virtual DateTime? LastModificationTime { get; set; }
    }
}