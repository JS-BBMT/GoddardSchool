using System;

namespace FranchiseePortal.Web.Swagger
{
    /// <summary>
    /// Attribute to mark controllers or actions to not be included in Swagger
    /// </summary>
    /// <remarks>
    /// 20220615RBP - FIX: Need to exclude actions marked with [SwaggerHideDocument] to fix
    /// the duplicated function generated in the service proxies (getProfilePictureByUser) error
    /// These error started happening when we enabled Swagger to expose MVC convention routes
    /// see: https://github.com/GoddardSystemsInc/ipaas-franchiseeportal-api/pull/148#discussion_r861901966
    /// </remarks>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
    public class SwaggerHideDocumentAttribute : Attribute
    {
    }
}
