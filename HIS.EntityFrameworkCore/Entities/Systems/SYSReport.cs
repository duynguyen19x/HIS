using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Systems
{
    [Table("SYSReport")]
    public class SYSReport : AuditedEntity<int>
    {
        [MaxLength(50)]
        public string ReportCode { get; set; }

        [MaxLength(255)]
        public string ReportName { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }

        public int ReportCategoryId { get; set; }

        [ForeignKey("ReportCategoryId")]
        public SYSReportCategory ReportCategoryFk { get; set; }
    }
}
