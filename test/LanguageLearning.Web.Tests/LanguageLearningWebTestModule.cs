using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LanguageLearning.EntityFrameworkCore;
using LanguageLearning.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace LanguageLearning.Web.Tests
{
    [DependsOn(
        typeof(LanguageLearningWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class LanguageLearningWebTestModule : AbpModule
    {
        public LanguageLearningWebTestModule(LanguageLearningEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LanguageLearningWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(LanguageLearningWebMvcModule).Assembly);
        }
    }
}