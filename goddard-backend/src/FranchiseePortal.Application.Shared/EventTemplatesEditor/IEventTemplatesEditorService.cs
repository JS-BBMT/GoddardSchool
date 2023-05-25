using FranchiseePortal.SchoolEventsWebApiClient.Model;
using System.Threading.Tasks;

namespace FranchiseePortal.EventTemplatesEditor
{
    public interface IEventTemplatesEditorService
    {
        Task<EventTemplate> CreateEventTemplate(PostEventTemplate eventTemplate);

        Task<EventTemplate> UpdateEventTemplate(long templateId, PostEventTemplate eventTemplate);

        Task DeleteEventTemplate(string crmId, long templateId);
    }
}
