using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using FranchiseePortal.Configure;
using FranchiseePortal.Startup;
using FranchiseePortal.Test.Base;

namespace FranchiseePortal.GraphQL.Tests
{
    [DependsOn(
        typeof(FranchiseePortalGraphQLModule),
        typeof(FranchiseePortalTestBaseModule))]
    public class FranchiseePortalGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FranchiseePortalGraphQLTestModule).GetAssembly());
        }
    }
}