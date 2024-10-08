﻿using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Mối quan hệ gia đình
    /// </summary>
    [Table("SRelationships")]
    public class Relationship : AuditedEntity<Guid>
    {
        [StringLength(RelationshipConst.MaxRelationshipCodeLength, MinimumLength = RelationshipConst.MinRelationshipCodeLength)]
        public string RelationshipCode { get; set; }

        [Required]
        [StringLength(RelationshipConst.MaxRelationshipNameLength, MinimumLength = RelationshipConst.MinRelationshipNameLength)]
        public string RelationshipName { get; set; }

        [StringLength(RelationshipConst.MaxDescriptionLength, MinimumLength = RelationshipConst.MinDescriptionLength)]
        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }
    }
}
