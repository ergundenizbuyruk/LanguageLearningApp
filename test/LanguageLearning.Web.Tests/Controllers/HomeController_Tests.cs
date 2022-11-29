using System.Threading.Tasks;
using LanguageLearning.Models.TokenAuth;
using LanguageLearning.Web.Controllers;
using Shouldly;
using Xunit;

namespace LanguageLearning.Web.Tests.Controllers
{
    public class HomeController_Tests: LanguageLearningWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}