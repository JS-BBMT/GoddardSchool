using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using FranchiseePortal.Dto;

namespace FranchiseePortal.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
