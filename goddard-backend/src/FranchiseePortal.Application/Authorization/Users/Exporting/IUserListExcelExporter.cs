using System.Collections.Generic;
using FranchiseePortal.Authorization.Users.Dto;
using FranchiseePortal.Dto;

namespace FranchiseePortal.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}