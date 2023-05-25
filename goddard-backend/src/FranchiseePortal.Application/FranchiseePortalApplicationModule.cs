using Abp.AutoMapper;
using Abp.Dependency;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using FranchiseePortal.AssetsEditor;
using FranchiseePortal.Authorization;
using FranchiseePortal.AuthorizationWebApiClient.Api;
using FranchiseePortal.CareersWebApiClient.Api;
using FranchiseePortal.Configuration;
using FranchiseePortal.ContentWebApiClient.Api;
using FranchiseePortal.Dependency;
using FranchiseePortal.FacultiesWebApiClient.Api;
using FranchiseePortal.FeaturesWebApiClient.Api;
using FranchiseePortal.LeadsWebApiClient.Api;
using FranchiseePortal.SchoolEventsWebApiClient.Api;
using FranchiseePortal.TestimonialsWebApiClient.Api;
using FranchiseePortal.Url;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using ISchoolsApi = FranchiseePortal.SchoolsWebApiClient.Api.ISchoolsApi;
using SchoolsApi = FranchiseePortal.SchoolsWebApiClient.Api.SchoolsApi;
using System.Runtime.CompilerServices;
using FranchiseePortal.ToursWebApiClient.Api;

[assembly: InternalsVisibleTo("FranchiseePortal.Tests")]

namespace FranchiseePortal
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(FranchiseePortalApplicationSharedModule),
        typeof(FranchiseePortalCoreModule)
        )]
    public class FranchiseePortalApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FranchiseePortalApplicationModule).GetAssembly());

            //Register external dependencies into aspnetzero IoCManager
            IocManager.Register<SchoolUrlFactory, SchoolUrlFactory>(DependencyLifeStyle.Transient);

            // Register API clients
            RegisterApiClients();            
        }

        /// <summary>
        /// Register API clients
        /// </summary>
        public void RegisterApiClients()
        {
            RegisterApiClient<IFeaturesApi, FeaturesApi, FeaturesWebApiClient.Client.Configuration>(
              ApiClientConfiguration.FEATURES_SECTION);

            RegisterApiClient<ISchoolsApi, SchoolsApi, SchoolsWebApiClient.Client.Configuration>(
              ApiClientConfiguration.SCHOOLS_SECTION);

            RegisterApiClient<IFacultyBiosApi, FacultyBiosApi, FacultiesWebApiClient.Client.Configuration>(
               ApiClientConfiguration.FACULTY_SECTION);

            RegisterApiClient<ITestimonialsApi, TestimonialsApi, TestimonialsWebApiClient.Client.Configuration>(
               ApiClientConfiguration.TESTIMONIALS_SECTION);

            RegisterApiClient<ICareersApi, CareersApi, CareersWebApiClient.Client.Configuration>(
               ApiClientConfiguration.CAREERS_SECTION);

            RegisterApiClient<IAuthorizedSchoolsApi, AuthorizedSchoolsApi, AuthorizationWebApiClient.Client.Configuration>(
                ApiClientConfiguration.AUTHORIZATION_SECTION);

            RegisterApiClient<ContentWebApiClient.Client.Configuration>(
                ApiClientConfiguration.CONTENT_SECTION,
                ApiClientRegistration.Create<IAssetsApi, AssetsApi>(),
                ApiClientRegistration.Create<ContentWebApiClient.Api.ISchoolsApi, ContentWebApiClient.Api.SchoolsApi>(),
                ApiClientRegistration.Create<IExtendedAssetsApi, ExtendedAssetsApiForCookieManagement>(),
                ApiClientRegistration.Create<IComponentsApi, ComponentsApi>(),
                ApiClientRegistration.Create<ISiteMarketingToolApi, SiteMarketingToolApi>(),
                ApiClientRegistration.Create<ITooltipsApi, TooltipsApi>()
                );

            RegisterApiClient<SchoolEventsWebApiClient.Client.Configuration>(
                ApiClientConfiguration.EVENTS_SECTION,
                ApiClientRegistration.Create<IEventTemplatesApi, EventTemplatesApi>(),
                ApiClientRegistration.Create<IEventsApi, EventsApi>());

            RegisterApiClient<ToursWebApiClient.Client.Configuration>(
                ApiClientConfiguration.TOURS_SECTION,
                ApiClientRegistration.Create<IToursApi, ToursApi>(),
                ApiClientRegistration.Create<IGuidesApi, GuidesApi>(),
                ApiClientRegistration.Create<IScheduleApi, ScheduleApi>());

            RegisterApiClient<ISchoolParentLeadsApi, SchoolParentLeadsApi, LeadsWebApiClient.Client.Configuration>(
                ApiClientConfiguration.LEADS_SECTION);
        }


        /// <summary>
        /// Registers multiple API client APIs with a single configuration
        /// </summary>
        /// <typeparam name="TApiClientConfiguration"></typeparam>
        /// <param name="configSection"></param>
        /// <param name="registrations"></param>
        public void RegisterApiClient<TApiClientConfiguration>(
            string configSection,
            params ApiClientRegistration[] registrations)
            where TApiClientConfiguration : class, new()
        {
            RegisterApiClientConfiguration<TApiClientConfiguration>(configSection);
            IocManager.IocContainer.Register(registrations); 
        }

        /// <summary>
        /// Registers single API client API and configuration
        /// </summary>
        /// <typeparam name="TApiClientType"></typeparam>
        /// <typeparam name="TApiClientImpl"></typeparam>
        /// <typeparam name="TApiClientConfiguration"></typeparam>
        /// <param name="configSection"></param>
        public void RegisterApiClient<TApiClientType, TApiClientImpl, TApiClientConfiguration>(
            string configSection)
            where TApiClientType : class
            where TApiClientImpl : class, TApiClientType
            where TApiClientConfiguration : class, new()
        {
            RegisterApiClientConfiguration<TApiClientConfiguration>(configSection);

            IocManager.Register<TApiClientType, TApiClientImpl>(DependencyLifeStyle.Transient);
        }

        /// <summary>
        /// Register API client configuration
        /// </summary>
        /// <typeparam name="TApiClientConfiguration"></typeparam>
        /// <param name="configSection"></param>
        public void RegisterApiClientConfiguration<TApiClientConfiguration>(
            string configSection)
            where TApiClientConfiguration : class, new()
        {
            // Default Castle registration lifetime is Singleton
            // see: https://github.com/castleproject/Windsor/blob/master/docs/registering-components-one-by-one.md#configuring-components-lifestyle
            IocManager.IocContainer.Register(
               Component.For<TApiClientConfiguration>()
                   .UsingFactoryMethod(kernel =>
                   {
                       var appConfig = kernel.Resolve<IAppConfigurationAccessor>().Configuration;

                       var apiConfig = appConfig.GetSection(configSection)
                           .Get<ApiClientConfiguration>();

                       var result = new TApiClientConfiguration();
                       var type = result.GetType();

                       // Set BasePath
                       var prop = type.GetProperty(nameof(LeadsWebApiClient.Client.Configuration.BasePath));
                       prop.SetValue(result, apiConfig.APIUrl, null);

                       // Set API key via DefaultHeaders
                       prop = type.GetProperty(nameof(LeadsWebApiClient.Client.Configuration.DefaultHeaders));
                       prop.SetValue(result, new Dictionary<string, string> { { "Ocp-Apim-Subscription-Key", appConfig["App:ApiKey"] } }, null);

                       return result;
                   }));
        }
    }
}
