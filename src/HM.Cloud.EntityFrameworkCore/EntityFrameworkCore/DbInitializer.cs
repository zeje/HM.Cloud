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

            var users = new User[] {
                new User(){
                    Birthday = DateTime.Now,
                    CreationTime = DateTime.Now,
                    CreatorUserId = Guid.Empty,
                    Email = "",
                    IDCard = "",
                    LastModificationTime = null,
                    LastModifierUserId = Guid.Empty,
                    LoginFailedTimes = 0,
                    LoginCount = 0,
                    LoginIp = "",
                    PassWord = "",
                    LoginTime = null,
                    PasswordSetTime = DateTime.Now,
                    RegisterIp = "",
                    Phone = "",
                    RegisterTime = DateTime.Now,
                    Sex = null,
                    TrueName = "test",
                    UserName = "test"
                }
            };



            var pages = new Page[]
            {
                new Page(){
                    CreationTime = DateTime.Now,
                    CreatorUserId = Guid.Empty,
                    Description = "",
                    Icon = "",
                    IsVisible = true,
                    LastModifierUserId = Guid.Empty,
                    Name = "菜单",

                }
            };

            context.Pages.AddRange(pages);
            context.SaveChanges();
        }
    }
}
