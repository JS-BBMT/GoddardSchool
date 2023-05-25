using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using FranchiseePortal.FacultiesWebApiClient.Model;

namespace FranchiseePortal.FacultyEditor
{
    public interface IFacultyEditorService : IApplicationService
    {
        Task SaveFaculty(List<PostFacultyBiosRequest> postFacultyBiosRequest);

        Task DeleteFacultyImage(long fmsSchoolId, string filename);
    }
}
