using System.Collections.Generic;
using FranchiseePortal.Authorization.Permissions.Dto;

namespace FranchiseePortal.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}