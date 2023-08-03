using HIS.Core.Entities;
using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Business.Patients;
using HIS.EntityFrameworkCore.Entities.Categories.Medicines;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Loại bệnh nhân.
    /// </summary>
    public class SPatientType : AuditedEntity<int>
    {
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int SortOrder { get; set; }
        public virtual bool Inactive { get; set; }

        //public virtual ICollection<SPatient> SPatients { get; set; }
        public virtual ICollection<SServicePricePolicy> SServicePricePolicies { get; set; }
        public virtual ICollection<SMedicinePricePolicy> SMedicinePricePolicies { get; set; }
    }
}
