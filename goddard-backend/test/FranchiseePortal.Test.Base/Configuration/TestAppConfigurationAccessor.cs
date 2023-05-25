using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using FranchiseePortal.Configuration;

namespace FranchiseePortal.Test.Base.Configuration
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(FranchiseePortalTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
