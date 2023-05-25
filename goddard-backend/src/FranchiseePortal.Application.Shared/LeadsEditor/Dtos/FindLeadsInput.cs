using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FranchiseePortal.LeadsEditor.Dtos
{
    public class FindLeadsInput
    {
        public string Q { get; set; }

        /// <summary>
        /// School CRM ID to query leads for
        /// </summary>
        [Required]
        public string SchoolId { get; set; }

        /// <summary>
        /// for searching parent or children first/last name
        /// </summary>
        public string LeadName { get; set; }

        /// <summary>
        /// for searching all childrens ages
        /// </summary>
        public int? ChildAge { get; set; }

        /// <summary>
        /// Filter Preferred Start Date
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Filter Preferred End Date
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// List of searched programs that the School Parent Leads may be interested in
        /// </summary>
        public List<string> ProgramsOfInterest { get; set; }
    }
}
