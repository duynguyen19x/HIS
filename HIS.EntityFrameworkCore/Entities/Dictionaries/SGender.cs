using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Business.Patients;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    public class SGender : AuditedEntity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? SortOrder { get; set; }
        public bool Inactive { get; set; }

        public IList<SPatient> SPatients { get; set; }
    }
}
