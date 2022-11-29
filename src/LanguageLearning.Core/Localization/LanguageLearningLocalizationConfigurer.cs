using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace LanguageLearning.Localization
{
    public static class LanguageLearningLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(LanguageLearningConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(LanguageLearningLocalizationConfigurer).GetAssembly(),
                        "LanguageLearning.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
