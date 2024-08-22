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
    /// <summary>
    /// Số thứ tự bệnh nhân (theo năm)
    /// </summary>
    [Table("DPatientNumbers")]
    public class PatientNumber : Entity<Guid>
    {
        [Required]
        public DateTime PatientNumberDate { get; set; } // ngày cấp phát

        [Required]
        public int NumOrder { get; set; } // số thứ tự
    }
}
