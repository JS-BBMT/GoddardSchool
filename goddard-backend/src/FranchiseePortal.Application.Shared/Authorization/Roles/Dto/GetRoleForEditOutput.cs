using System.Collections.Generic;
using FranchiseePortal.Authorization.Permissions.Dto;

namespace FranchiseePortal.Authorization.Roles.Dto
{
    public class GetRoleForEditOutput
    {
        public RoleEditDto Role { get; set; }

        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}