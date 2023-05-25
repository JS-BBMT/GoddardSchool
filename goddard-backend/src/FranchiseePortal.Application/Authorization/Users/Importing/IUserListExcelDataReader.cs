using System.Collections.Generic;
using FranchiseePortal.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace FranchiseePortal.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
