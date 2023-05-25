using Abp.Application.Services.Dto;

namespace FranchiseePortal.Authorization.Users.Dto
{
    public interface IGetLoginAttemptsInput: ISortedResultRequest
    {
        string Filter { get; set; }
    }
}