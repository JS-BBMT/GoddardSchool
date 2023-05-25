using System.Collections.Generic;
using Abp.Runtime.Session;
using Abp.Timing.Timezone;
using FranchiseePortal.DataExporting.Excel.NPOI;
using FranchiseePortal.ResourceLinks.Dtos;
using FranchiseePortal.Dto;
using FranchiseePortal.Storage;

namespace FranchiseePortal.ResourceLinks.Exporting
{
    public class ResourceLinksExcelExporter : NpoiExcelExporterBase, IResourceLinksExcelExporter
    {

        private readonly ITimeZoneConverter _timeZoneConverter;
        private readonly IAbpSession _abpSession;

        public ResourceLinksExcelExporter(
            ITimeZoneConverter timeZoneConverter,
            IAbpSession abpSession,
            ITempFileCacheManager tempFileCacheManager) :
    base(tempFileCacheManager)
        {
            _timeZoneConverter = timeZoneConverter;
            _abpSession = abpSession;
        }

        public FileDto ExportToFile(List<GetResourceLinkForViewDto> resourceLinks)
        {
            return CreateExcelPackage(
                "ResourceLinks.xlsx",
                excelPackage =>
                {

                    var sheet = excelPackage.CreateSheet(L("ResourceLinks"));

                    AddHeader(
                        sheet,
                        L("Text"),
                        L("Url"),
                        L("Icon")
                        );

                    AddObjects(
                        sheet, resourceLinks,
                        _ => _.ResourceLink.Text,
                        _ => _.ResourceLink.Url,
                        _ => _.ResourceLink.Icon
                        );

                });
        }
    }
}