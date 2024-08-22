using HIS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    [Table("DMedicalRecordNumbers")]
    public class MedicalRecordNumber : Entity<Guid>
    {
        [Required]
        public DateTime MedicalRecordNumberDate { get; set; }

        [Required]
        public int NumOrder { get; set; }
    }
}
