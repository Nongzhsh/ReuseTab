using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace ReuseTab.Localization
{
    public static class ReuseTabLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(ReuseTabConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(ReuseTabLocalizationConfigurer).GetAssembly(),
                        "ReuseTab.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
