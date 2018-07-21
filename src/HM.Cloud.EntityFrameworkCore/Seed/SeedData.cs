using Abp.Timing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace HM.Cloud.EntityFrameworkCore
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CloudDbContext(serviceProvider.GetRequiredService<DbContextOptions<CloudDbContext>>()))
            {
                if (context.Users.Any())
                {
                    return;   // 已经初始化过数据，直接返回
                }
                Guid departmentId = Guid.NewGuid();
                #region 增加一个部门
                context.Departments.Add(
                   new Department
                   {
                       Id = departmentId,
                       ParentId = Guid.Empty,
                       Name = "牵心集团总部",
                       Description = "牵心集团是一个虚拟的集团",
                       CreatorUserId = Guid.Empty,
                       LastModifierUserId = Guid.Empty,
                   }
                );
                #endregion
                #region 增加一个超级管理员用户
                context.Users.Add(
                             new User
                             {
                                 UserName = "admin",
                                 PassWord = Zeje.Utils.Encrypt_.SHA256("123456"),
                                 TrueName = "超级管理员",
                                 Sex = null,
                                 Birthday = Clock.Now,
                                 Phone = "",
                                 Email = "",
                                 IDCard = "",
                                 UserStatus = UserStatus.启用,
                                 LoginIp = "",
                                 LoginTime = Clock.Now,
                                 LoginCount = 0,
                                 LoginFailedTimes = null,
                                 RegisterIp = "",
                                 RegisterTime = Clock.Now,
                                 PasswordSetTime = Clock.Now,
                                 Departments = null,
                                 UserRoles = null,
                                 CreatorUserId = Guid.Empty,
                                 LastModifierUserId = Guid.Empty,
                             }
                        );
                #endregion
                #region 增加基本功能菜单
                var pagePlatform = new Page
                {
                    Name = "平台管理",
                    Description = "平台管理",
                    ParentId = Guid.Empty,
                    Sort = 0,
                    Icon = "fa fa-link",
                    Url = "",
                    IsVisible = true,
                    CreatorUserId = Guid.Empty,
                    LastModifierUserId = Guid.Empty
                };
                var pageSystem = new Page
                {
                    Name = "平台管理",
                    Description = "平台管理",
                    ParentId = Guid.Empty,
                    Sort = 0,
                    Icon = "fa fa-link",
                    Url = "",
                    IsVisible = true,
                    CreatorUserId = Guid.Empty,
                    LastModifierUserId = Guid.Empty
                };
                var subPage = new Page[] {
                    new Page
                   {
                       Name = "组织机构管理",
                       Description = "组织机构管理",
                       ParentId = Guid.Empty,
                       Sort = 0,
                       Icon = "fa fa-link",
                       Url = "",
                       IsVisible = true,
                       CreatorUserId = Guid.Empty,
                       LastModifierUserId = Guid.Empty
                   },
                   new Page
                   {
                       Name = "角色管理",
                       Description = "角色管理",
                       ParentId = Guid.Empty,
                       Sort = 0,
                       Icon = "fa fa-link",
                       Url = "",
                       IsVisible = true,
                       CreatorUserId = Guid.Empty,
                       LastModifierUserId = Guid.Empty
                   },
                   new Page
                   {
                       Name = "用户管理",
                       Description = "用户管理",
                       ParentId = Guid.Empty,
                       Sort = 0,
                       Icon = "fa fa-link",
                       Url = "",
                       IsVisible = true,
                       CreatorUserId = Guid.Empty,
                       LastModifierUserId = Guid.Empty
                   },
                   new Page
                   {
                       Name = "功能管理",
                       Description = "功能管理",
                       ParentId = Guid.Empty,
                       Sort = 0,
                       Icon = "fa fa-link",
                       Url = "",
                       IsVisible = true,
                       CreatorUserId = Guid.Empty,
                       LastModifierUserId = Guid.Empty
                   }
                };
                foreach (var page in subPage)
                {
                    pageSystem.SubPages.Add(page);
                }
                pagePlatform.SubPages.Add(pageSystem);
                context.Pages.Add(pagePlatform);
                #endregion
                context.SaveChanges();
            }
        }
    }
}
