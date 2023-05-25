using Abp.Modules;
using Abp.Reflection.Extensions;

namespace FranchiseePortal
{
    [DependsOn(typeof(FranchiseePortalCoreSharedModule))]
    public class FranchiseePortalApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FranchiseePortalApplicationSharedModule).GetAssembly());
        }
    }
}