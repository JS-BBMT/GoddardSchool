using Microsoft.Extensions.Configuration;

namespace FranchiseePortal.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
