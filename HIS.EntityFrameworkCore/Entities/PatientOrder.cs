using HIS.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Số thứ tự bệnh nhân (theo năm)
    /// </summary>
    public class PatientOrder : Entity<Guid>
    {
        public DateTime PatientOrderDate { get; set; } // ngày cấp phát
        public int SortOrder { get; set; } // số thứ tự
    }
}
