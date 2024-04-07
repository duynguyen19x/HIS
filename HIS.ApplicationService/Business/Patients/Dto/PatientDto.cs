using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Patients.Dto
{
    public class PatientDto : EntityDto<Guid?>
    {
        public virtual string Code { get; set; }

        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual DateTime? BirthDate { get; set; }

        public virtual int BirthYear { get; set; }

        public virtual string BirthPlace { get; set; }

        public virtual Guid? GenderId { get; set; }

        public virtual string GenderName { get; set; }

        public virtual Guid? EthnicId { get; set; }

        public virtual string EthnicName { get; set; }

        public virtual Guid? ReligionId { get; set; }

        public virtual string ReligionName { get; set; }

        public virtual Guid? CountryId { get; set; }

        public virtual string CountryName { get; set; }

        public virtual Guid? ProvinceId { get; set; }

        public virtual string ProvinceName { get; set; }

        public virtual Guid? DistrictId { get; set; }

        public virtual string DistrictName { get; set; }

        public virtual Guid? WardId { get; set; }

        public virtual string WardName { get; set; }

        public virtual string Address { get; set; }

        public virtual Guid? CareerId { get; set; }

        public virtual string CareerName { get; set; }

        public virtual string WorkPlace { get; set; }

        public virtual Guid? BloodTypeId { get; set; }

        public virtual string BloodTypeCode { get; set; }

        public virtual Guid? BloodTypeRhId { get; set; }

        public virtual string BloodTypeRhCode { get; set; }

        public virtual string IdentificationNumber { get; set; }

        public virtual DateTime? IssueDate { get; set; }

        public virtual string IssueBy { get; set; }

        public virtual string Tel { get; set; }

        public virtual string Mobile { get; set; }

        public virtual string Email { get; set; }


        public virtual string ContactName { get; set; }

        public virtual string ContactType { get; set; }

        public virtual string ContactAddress { get; set; }

        public virtual string ContactTel { get; set; }

        public virtual string ContactMobile { get; set; }

        public virtual string ContactIdentificationNumber { get; set; }

        public virtual DateTime? ContactIssueDate { get; set; }

        public virtual string ContactIssueBy { get; set; }
    }
}
