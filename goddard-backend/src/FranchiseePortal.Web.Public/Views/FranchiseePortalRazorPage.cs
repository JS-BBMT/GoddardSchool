using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace FranchiseePortal.Web.Public.Views
{
    public abstract class FranchiseePortalRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected FranchiseePortalRazorPage()
        {
            LocalizationSourceName = FranchiseePortalConsts.LocalizationSourceName;
        }
    }
}
