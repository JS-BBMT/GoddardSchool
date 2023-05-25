using System.Collections.Generic;
using FranchiseePortal.Authorization.Users.Importing.Dto;
using FranchiseePortal.Dto;

namespace FranchiseePortal.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
