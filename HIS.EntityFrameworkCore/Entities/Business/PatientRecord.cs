using AutoMapper.Configuration.Annotations;
using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Thông tin đợt điều trị của bệnh nhân.
    /// </summary>
    public class PatientRecord : FullAuditedEntity<Guid>
    {
        public virtual string Code { get; set; }

        public virtual Guid PatientId { get; set; }
        public virtual string PatientName { get; set; }
        public virtual string IdentificationNumber { get; set; }
        public virtual DateTime? IssueDate { get; set; }
        public virtual string IssueBy { get; set; }

        public virtual DateTime? BirthDate { get; set; }
        public virtual int BirthYear { get; set; }
        public virtual string BirthPlace { get; set; }
        public virtual Guid GenderId { get; set; }
        public virtual Guid CareerId { get; set; }
        public virtual Guid EthnicityId { get; set; }
        public virtual Guid CountryId { get; set; }
        public virtual Guid? ProvinceOrCityId { get; set; }
        public virtual Guid? DistrictId { get; set; }
        public virtual Guid? WardId { get; set; }
        public virtual string Address { get; set; }
        public virtual string Workplace { get; set; }


        public virtual Guid ReceptionUserId { get; set; } 
        public virtual Guid ReceptionDepartmentId { get; set; }
        public virtual Guid ReceptionRoomId { get; set; }
        public virtual DateTime ReceptionDate { get; set; }
        public virtual int ReceptionTypeId { get; set; }



        public PatientRecord() { }
    }
}
