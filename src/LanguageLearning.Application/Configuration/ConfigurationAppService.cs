using Abp.Authorization;
using Abp.Runtime.Session;
using LanguageLearning.Configuration.Dto;
using System.Threading.Tasks;

namespace LanguageLearning.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : LanguageLearningAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
