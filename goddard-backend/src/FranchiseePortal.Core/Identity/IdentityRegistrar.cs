using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using FranchiseePortal.Authentication.TwoFactor.Google;
using FranchiseePortal.Authorization;
using FranchiseePortal.Authorization.Roles;
using FranchiseePortal.Authorization.Users;
using FranchiseePortal.Editions;
using FranchiseePortal.MultiTenancy;
using Microsoft.Extensions.Logging;

namespace FranchiseePortal.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            // 20220114RBP - Redirecting logging to log4net so that
            // all our config logging is in one place
            //services.AddLogging();
            services.AddLogging(logging =>
            {
                logging.ClearProviders();
                logging.AddLog4Net();
            });

            return services.AddAbpIdentity<Tenant, User, Role>(options =>
                {
                    options.Tokens.ProviderMap[GoogleAuthenticatorProvider.Name] = new TokenProviderDescriptor(typeof(GoogleAuthenticatorProvider));
                })
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
