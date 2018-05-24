using Abp.Timing;
using System;
using System.Collections.Generic;
using System.Text;
namespace HM.Cloud
{
    public static class DbInitializer
    {
        public static void Initialize(CloudDbContext context)
        {
            context.Database.EnsureCreated();

            var users = new List<User>();
            for (int i = 0; i < 10; i++)
            {
                users.Add(new User()
                {
                    UserName = "test" + i,
                    PassWord = "test" + i,
                    TrueName = "test" + i,
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
                    UserRoles = null
                });
            }
            context.Users.AddRange(users);
            context.SaveChanges();
            var pages = new List<Page>();
            for (int i = 0; i < 10; i++)
            {
                pages.Add(new Page()
                {
                    CreationTime = Clock.Now,
                    CreatorUserId = Guid.Empty,
                    Description = "",
                    Icon = "",
                    IsVisible = true,
                    LastModifierUserId = Guid.Empty,
                    Name = "菜单" + i
                });
            }
            context.Pages.AddRange(pages);
            context.SaveChanges();
        }
    }
}
