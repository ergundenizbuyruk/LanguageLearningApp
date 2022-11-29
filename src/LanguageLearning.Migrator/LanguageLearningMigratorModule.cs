using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using LanguageLearning.Configuration;
using LanguageLearning.EntityFrameworkCore;
using LanguageLearning.Migrator.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace LanguageLearning.Migrator
{
    [DependsOn(typeof(LanguageLearningEntityFrameworkModule))]
    public class LanguageLearningMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public LanguageLearningMigratorModule(LanguageLearningEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(LanguageLearningMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                LanguageLearningConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus),
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LanguageLearningMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
