using System.Threading.Tasks;
using HM.Cloud.Web.Controllers;
using Shouldly;
using Xunit;

namespace HM.Cloud.Web.Tests.Controllers
{
    public class HomeController_Tests: CloudWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
