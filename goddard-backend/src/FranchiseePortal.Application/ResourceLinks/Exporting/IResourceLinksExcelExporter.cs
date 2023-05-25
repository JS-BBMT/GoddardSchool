using System.Collections.Generic;
using FranchiseePortal.ResourceLinks.Dtos;
using FranchiseePortal.Dto;

namespace FranchiseePortal.ResourceLinks.Exporting
{
    public interface IResourceLinksExcelExporter
    {
        FileDto ExportToFile(List<GetResourceLinkForViewDto> resourceLinks);
    }
}