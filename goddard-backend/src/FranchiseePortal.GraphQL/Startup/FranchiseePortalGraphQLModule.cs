using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace FranchiseePortal.Startup
{
    [DependsOn(typeof(FranchiseePortalCoreModule))]
    public class FranchiseePortalGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FranchiseePortalGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}