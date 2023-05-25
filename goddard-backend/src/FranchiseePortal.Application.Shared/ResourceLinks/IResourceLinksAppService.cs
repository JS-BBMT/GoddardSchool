using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FranchiseePortal.ResourceLinks.Dtos;
using FranchiseePortal.Dto;

namespace FranchiseePortal.ResourceLinks
{
    public interface IResourceLinksAppService : IApplicationService
    {
        Task<PagedResultDto<GetResourceLinkForViewDto>> GetAll(GetAllResourceLinksInput input);

        Task<GetResourceLinkForViewDto> GetResourceLinkForView(int id);

        Task<GetResourceLinkForEditOutput> GetResourceLinkForEdit(EntityDto input);

        Task CreateOrEdit(CreateOrEditResourceLinkDto input);

        Task Delete(EntityDto input);

        Task<FileDto> GetResourceLinksToExcel(GetAllResourceLinksForExcelInput input);

    }
}