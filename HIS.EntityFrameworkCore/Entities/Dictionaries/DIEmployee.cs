using HIS.Core.Domain.Entities;
using HIS.Core.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Nhân viên.
    /// </summary>
    public class DIEmployee : AuditedEntity<Guid>
    {
        /// <summary>
        /// Mã nhân viên.
        /// </summary>
        public string EmployeeCode { get; set; }

        /// <summary>
        /// Tên nhân viên.
        /// </summary>
        public string EmployeeName { get; set; }

        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }
    }
}
