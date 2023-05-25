using Abp.Domain.Services;

namespace FranchiseePortal
{
    public abstract class FranchiseePortalDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected FranchiseePortalDomainServiceBase()
        {
            LocalizationSourceName = FranchiseePortalConsts.LocalizationSourceName;
        }
    }
}
