using System.ComponentModel;

namespace FranchiseePortal.FacultyEditor.Dto
{
    public enum JobCategoryEnum
    {
        [Description("Assistant Teacher")]
        AssistantTeacher = 2,
        Director = 3,
        [Description("Lead Teacher")]
        LeadTeacher = 5,
        Owner = 10,
        [Description("Assistant Director")]
        AssistantDirector = 11,
        Resource = 12
    }
}
