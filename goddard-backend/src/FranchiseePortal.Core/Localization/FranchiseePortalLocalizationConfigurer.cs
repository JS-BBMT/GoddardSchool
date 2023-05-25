using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace FranchiseePortal.Localization
{
    public static class FranchiseePortalLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    FranchiseePortalConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(FranchiseePortalLocalizationConfigurer).GetAssembly(),
                        "FranchiseePortal.Localization.FranchiseePortal"
                    )
                )
            );
        }
    }
}