using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LanguageLearning.Controllers
{
    public abstract class LanguageLearningControllerBase : AbpController
    {
        protected LanguageLearningControllerBase()
        {
            LocalizationSourceName = LanguageLearningConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
