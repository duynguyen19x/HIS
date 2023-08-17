using AutoMapper.Configuration.Annotations;
using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Thông tin đợt điều trị của bệnh nhân.
    /// </summary>
    public class PatientRecord : FullAuditedEntity<Guid>
    {
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual Guid PatientId { get; set; }
        public virtual string PatientName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int BirthYear { get; set; }
        public string BirthPlace { get; set; }
        public virtual string IdentificationNumber { get; set; } // số CMND / CCCD
        public virtual DateTime? IssueDate { get; set; } // ngày cấp
        public virtual string IssueBy { get; set; } // nơi cấp
        public virtual Guid GenderId { get; set; }
        public virtual Guid EthnicityId { get; set; }
        public virtual Guid CareerId { get; set; }
        public virtual Guid CountryId { get; set; }
        public virtual Guid? ProvinceId { get; set; }
        public virtual Guid? DistrictId { get; set; }
        public virtual Guid? WardId { get; set; }
        public virtual string Address { get; set; }
        public virtual string Tel { get; set; }
        public virtual string Mobile { get; set; }
        public virtual string Fax { get; set; }
        public virtual string Email { get; set; }
        public virtual int PatientTypeId { get; set; }
        public virtual bool Inactive { get; set; }

        [Ignore]
        public virtual Patient Patient { get; set; }
        [Ignore]
        public virtual SGender SGender { get; set; }
        [Ignore]
        public virtual SEthnic SEthnic { get; set; }
        [Ignore]
        public virtual SCareer SCareer { get; set; }
        [Ignore]
        public virtual SCountry SCountry { get; set; }
        [Ignore]
        public virtual SProvince SProvince { get; set; }
        [Ignore]
        public virtual SDistrict SDistrict { get; set; }
        [Ignore]
        public virtual SWard SWard { get; set; }
    }
}
