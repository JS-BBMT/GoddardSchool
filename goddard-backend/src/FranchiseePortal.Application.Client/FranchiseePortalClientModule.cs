using Abp.Modules;
using Abp.Reflection.Extensions;

namespace FranchiseePortal
{
    public class FranchiseePortalClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FranchiseePortalClientModule).GetAssembly());
        }
    }
}
