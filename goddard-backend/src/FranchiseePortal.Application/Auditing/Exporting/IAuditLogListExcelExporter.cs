using System.Collections.Generic;
using FranchiseePortal.Auditing.Dto;
using FranchiseePortal.Dto;

namespace FranchiseePortal.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
