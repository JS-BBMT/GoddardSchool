using FranchiseePortal.SchoolEventsWebApiClient.Model;
using System.Threading.Tasks;

namespace FranchiseePortal.EventsEditor
{
    public interface IEventsEditorService
    {
        Task<PostEvents> SaveEvent(PostEvents postEvents);
    }
}
