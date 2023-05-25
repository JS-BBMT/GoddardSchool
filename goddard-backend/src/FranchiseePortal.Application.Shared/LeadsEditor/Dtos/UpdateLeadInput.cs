using FranchiseePortal.LeadsWebApiClient.Model;
using System;
using System.Collections.Generic;

namespace FranchiseePortal.LeadsEditor.Dtos
{
    public class UpdateLeadInput
    {
        public Guid GuidId { get; set; }

        public List<TourLeadChildInput> SchoolChildLeads { get; set; }

        public List<DaysOfInterest> DaysOfInterest { get; set; }

        public List<string> ProgramsOfInterest { get; set; }

        public string TourQuestions { get; set; }

        public static ApiV1SchoolLeadsIdTourPutRequest CreateLeadUpdateRequest(UpdateLeadInput input)
        {
            return new ApiV1SchoolLeadsIdTourPutRequest(input.SchoolChildLeads, input.DaysOfInterest, input.ProgramsOfInterest, input.TourQuestions);
        }
    }
}
