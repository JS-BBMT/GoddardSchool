using Abp.AspNetCore.Mvc.ViewComponents;

namespace FranchiseePortal.Web.Public.Views
{
    public abstract class FranchiseePortalViewComponent : AbpViewComponent
    {
        protected FranchiseePortalViewComponent()
        {
            LocalizationSourceName = FranchiseePortalConsts.LocalizationSourceName;
        }
    }
}