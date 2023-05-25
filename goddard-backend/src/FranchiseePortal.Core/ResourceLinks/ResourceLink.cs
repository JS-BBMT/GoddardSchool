using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;

namespace FranchiseePortal.ResourceLinks
{
    [Table("ResourceLinks")]
    public class ResourceLink : FullAuditedEntity
    {

        [Required]
        public virtual string Text { get; set; }

        [Required]
        public virtual string Url { get; set; }

        public virtual string Icon { get; set; }

        public bool IsExternal { get; set; }
    }
}