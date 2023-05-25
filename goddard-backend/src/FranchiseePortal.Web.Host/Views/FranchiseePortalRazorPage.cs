using Abp.AspNetCore.Mvc.Views;

namespace FranchiseePortal.Web.Views
{
    public abstract class FranchiseePortalRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected FranchiseePortalRazorPage()
        {
            LocalizationSourceName = FranchiseePortalConsts.LocalizationSourceName;
        }
    }
}
