using HIS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Số thứ tự bệnh nhân (theo năm)
    /// </summary>
    [Table("DPatientNumber")]
    public class PatientNumber : Entity<Guid>
    {
        public DateTime PatientOrderDate { get; set; } // ngày cấp phát
        public int SortOrder { get; set; } // số thứ tự
    }
}
