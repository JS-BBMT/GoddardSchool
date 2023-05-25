using System.Collections.Generic;
using Abp;
using FranchiseePortal.Chat.Dto;
using FranchiseePortal.Dto;

namespace FranchiseePortal.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
