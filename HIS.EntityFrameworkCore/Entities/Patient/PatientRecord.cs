using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Patient
{
    public class PatientRecord : FullAuditedEntity<Guid>
    {
        public virtual string Code { get; set; }
        public virtual Guid PatientId { get; set; }
        public virtual string PatientName { get; set; }
        public virtual DateTime? BirthDate { get; set; }
        public virtual int BirthYear { get; set; }
        public virtual string BirthPlace { get; set; }
        public virtual string IdentificationNumber { get; set; } // số CMND / CCCD
        public virtual DateTime? IssueDate { get; set; } // ngày cấp
        public virtual string IssueBy { get; set; } // nơi cấp
        public virtual Guid GenderId { get; set; }
        public virtual Guid EthnicId { get; set; }
        public virtual Guid CountryId { get; set; }
        public virtual Guid? ProvinceId { get; set; }
        public virtual Guid? DistrictId { get; set; }
        public virtual Guid? WardId { get; set; }
        public virtual string Address { get; set; }
        public virtual string Tel { get; set; }
        public virtual string Mobile { get; set; }
        public virtual string Fax { get; set; }
        public virtual string Email { get; set; }

        public virtual SGender Gender { get; set; }
        public virtual SEthnic Ethnic { get; set; }
        public virtual SCountry Country { get; set; }
        public virtual SProvince Province { get; set; }
        public virtual SDistrict District { get; set; }
        public virtual SWard Ward { get; set; }
    }
}
