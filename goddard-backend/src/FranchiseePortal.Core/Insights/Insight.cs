using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;

namespace FranchiseePortal.Insights
{
    [Table("Insights")]
    public class Insight : FullAuditedEntity
    {

        [Required]
        public virtual string Header { get; set; }

        [Required]
        public virtual string Body { get; set; }

        public virtual string Url { get; set; }

        public int? SortOrder { get; set; }
    }
}