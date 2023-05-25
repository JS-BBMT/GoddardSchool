using Abp.Authorization;
using FranchiseePortal.Authorization.Roles;
using FranchiseePortal.Authorization.Users;

namespace FranchiseePortal.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
