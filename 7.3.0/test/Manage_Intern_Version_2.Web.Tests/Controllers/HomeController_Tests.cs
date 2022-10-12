using System.Threading.Tasks;
using Manage_Intern_Version_2.Web.Controllers;
using Shouldly;
using Xunit;

namespace Manage_Intern_Version_2.Web.Tests.Controllers
{
    public class HomeController_Tests: Manage_Intern_Version_2WebTestBase
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
