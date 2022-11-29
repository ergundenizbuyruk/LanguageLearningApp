using Abp.Modules;
using Abp.Reflection.Extensions;
using LanguageLearning.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace LanguageLearning.Web.Host.Startup
{
    [DependsOn(
       typeof(LanguageLearningWebCoreModule))]
    public class LanguageLearningWebHostModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LanguageLearningWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LanguageLearningWebHostModule).GetAssembly());
        }
    }
}
