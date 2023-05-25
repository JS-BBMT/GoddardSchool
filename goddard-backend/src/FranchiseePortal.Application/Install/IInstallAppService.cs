using System.Threading.Tasks;
using Abp.Application.Services;
using FranchiseePortal.Install.Dto;

namespace FranchiseePortal.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}