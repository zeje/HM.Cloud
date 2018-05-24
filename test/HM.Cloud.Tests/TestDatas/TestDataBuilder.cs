

using Abp.Timing;
using System;
using System.Collections.Generic;

namespace HM.Cloud.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly CloudDbContext _context;

        public TestDataBuilder(CloudDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
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
                    UserStatus = UserStatus.ÆôÓÃ,
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
            _context.Users.AddRange(users);
            _context.SaveChanges();

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
                    Name = "²Ëµ¥" + i
                });
            }
            _context.Pages.AddRange(pages);
        }
    }
}