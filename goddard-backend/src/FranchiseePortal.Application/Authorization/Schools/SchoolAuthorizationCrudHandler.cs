using FranchiseePortal.Authorization.Roles;
using FranchiseePortal.AuthorizationWebApiClient.Api;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace FranchiseePortal.Authorization.Schools
{
    /// <summary>
    /// Handler to authorize school editor requirement
    /// Based on: https://docs.microsoft.com/en-us/aspnet/core/security/authorization/resourcebased?view=aspnetcore-5.0#operational-requirements
    /// </summary>
    public class SchoolAuthorizationCrudHandler :
        AuthorizationHandler<SchoolOperationAuthorizationRequirement, string>
    {
        private readonly IAuthorizedSchoolsApi _authorizationApi;

        public SchoolAuthorizationCrudHandler(IAuthorizedSchoolsApi authorizationApi) {
            _authorizationApi = authorizationApi;
        }

        protected async override Task HandleRequirementAsync(AuthorizationHandlerContext context,
                                                       SchoolOperationAuthorizationRequirement requirement,
                                                       string resource) {

            var user = context.User;

            // User is an admin, can manage any school
            if(user.IsInRole(StaticRoleNames.Host.Admin)) {
                context.Succeed(requirement);
                return;

            }

            // User is not an admin, check if user is explicitly authorized for this school
            var emailClaim = user.FindFirst(ClaimTypes.Email);
            if (emailClaim == null) {
                return;
            }

            var email = emailClaim.Value;
            if(string.IsNullOrEmpty(email)) {
                return;
            }

            var authorizedSchools = await _authorizationApi.ApiV1AuthorizedSchoolsGetAsync(email);

            if (authorizedSchools.Any(x => StringComparer.OrdinalIgnoreCase.Equals(resource, x.CrmId))) {
                context.Succeed(requirement);
            }
           
            return;
        }
    }
}
