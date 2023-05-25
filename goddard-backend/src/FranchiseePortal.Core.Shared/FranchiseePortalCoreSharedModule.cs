using Abp.Modules;
using Abp.Reflection.Extensions;

namespace FranchiseePortal
{
    public class FranchiseePortalCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FranchiseePortalCoreSharedModule).GetAssembly());
        }
    }
}