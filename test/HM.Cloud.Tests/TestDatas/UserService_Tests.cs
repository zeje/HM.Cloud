using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HM.Cloud.Tests.TestDatas
{
    public class UserAppService_Tests : CloudTestBase
    {
        private readonly IUserAppService _userAppService;

        public UserAppService_Tests()
        {
            _userAppService = Resolve<IUserAppService>();
        }

        [Fact]
        public async Task Should_Get_All_Users()
        {
            //Act
            var output = await _userAppService.GetAll(new GetAllUsersInput());

            //Assert
            output.Items.Count.ShouldBe(10);
        }

        [Fact]
        public async Task Should_Get_Filtered_Users()
        {
            //Act
            var output = await _userAppService.GetAll(new GetAllUsersInput { UserStatus = UserStatus.启用 });

            //Assert
            output.Items.ShouldAllBe(t => t.UserStatus == UserStatus.启用);
        }
    }
}
