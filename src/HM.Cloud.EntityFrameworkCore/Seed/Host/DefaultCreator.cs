using System;
using System.Collections.Generic;
using System.Linq;
using Abp.Timing;
using Microsoft.EntityFrameworkCore;

namespace HM.Cloud.EntityFrameworkCore.Seed.Host
{
    public class DefaultCreator
    {
        private readonly CloudDbContext _context;

        public DefaultCreator(CloudDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUsers();
            CreatePages();
        }

        private void CreateUsers()
        {
            for (int i = 0; i < 10; i++)
            {
                string userName = "test" + i;
                var defaultUser = _context.Users.IgnoreQueryFilters().FirstOrDefault(e => e.UserName == userName);
                if (defaultUser == null)
                {
                    _context.Users.Add(new User()
                    {
                        UserName = userName,
                        PassWord = "test" + i,
                        TrueName = "test" + i,
                        Sex = null,
                        Birthday = Clock.Now,
                        Phone = "",
                        Email = "",
                        IDCard = "",
                        UserStatus = UserStatus.∆Ù”√,
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
                _context.SaveChanges();
            }
        }
        private void CreatePages()
        {
            var pages = new List<Page>();
            for (int i = 0; i < 10; i++)
            {
                string pageName = "≤Àµ•" + i;
                var defaultPage = _context.Pages.IgnoreQueryFilters().FirstOrDefault(e => e.Name == pageName);
                if (defaultPage == null)
                {
                    _context.Pages.Add(new Page()
                    {
                        CreationTime = Clock.Now,
                        CreatorUserId = Guid.Empty,
                        Description = "",
                        Icon = "",
                        IsVisible = true,
                        LastModifierUserId = Guid.Empty,
                        Name = pageName
                    });
                }
            }
            _context.SaveChanges();
        }
    }
}
