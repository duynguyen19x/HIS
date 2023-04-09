using HIS.EntityFrameworkCore.BaseEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories.Patients
{
    public class SPatientType : Entity<Guid>
    {
        /// <summary>
        /// Mã đối tượng BN
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Tên đối tượng BN    
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Trạng thái
        /// </summary>
        public bool IsActive { get; set; }

        public IList<SPatient> SPatients { get; set; }
    }
}
