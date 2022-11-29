using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LanguageLearning.Authorization;

namespace LanguageLearning
{
    [DependsOn(
        typeof(LanguageLearningCoreModule),
        typeof(AbpAutoMapperModule))]
    public class LanguageLearningApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LanguageLearningAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LanguageLearningApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
