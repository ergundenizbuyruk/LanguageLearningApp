using LanguageLearning.Configuration.Dto;
using System.Threading.Tasks;

namespace LanguageLearning.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
