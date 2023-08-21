using HIS.Application.Core.Services.Dto;

namespace HIS.Dtos.Business
{
    public class PatientRecordDto : EntityDto<Guid?>
    {
        public virtual string Code { get; set; }

        public virtual Guid? PatientId { get; set; }

        public virtual string PatientCode { get; set; }

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

        public virtual Guid BranchId { get; set; }

        public virtual string Address { get; set; }

        public virtual string Tel { get; set; }

        public virtual string Mobile { get; set; }

        public virtual string Fax { get; set; }

        public virtual string Email { get; set; }

        public virtual int PatientTypeId { get; set; }

        public virtual int PatientRecordTypeId { get; set; }

        public virtual string Description { get; set; }

        public virtual bool Inactive { get; set; }
    }
}
