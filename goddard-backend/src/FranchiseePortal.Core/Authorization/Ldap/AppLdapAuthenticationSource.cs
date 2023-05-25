using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using FranchiseePortal.Authorization.Users;
using FranchiseePortal.MultiTenancy;

namespace FranchiseePortal.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}