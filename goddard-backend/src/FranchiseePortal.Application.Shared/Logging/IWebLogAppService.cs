using Abp.Application.Services;
using FranchiseePortal.Dto;
using FranchiseePortal.Logging.Dto;

namespace FranchiseePortal.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
