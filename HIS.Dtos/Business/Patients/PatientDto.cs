using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.Patients
{
    /// <summary>
    /// Thông tin định danh bệnh nhân.
    /// </summary>
    public class PatientDto : EntityDto<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public int BirthYear { get; set; }
        public string BirthPlace { get; set; }
        public Guid GenderId { get; set; }
        public string GenderCode { get; set; }
        public string GenderName { get; set; }
        public Guid EthnicId { get; set; }
        public string EthnicCode { get; set; }
        public string EthnicName { get; set; }
        public Guid? BloodTypeId { get; set; }
        public string BloodTypeCode { get; set; }
        public string BloodTypeName { get; set; }
        public Guid? BloodTypeRhId { get; set; }
        public string BloodTypeRhCode { get; set; }
        public string BloodTypeRhName { get; set; }
        public Guid? CountryId { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public Guid? ProvinceOrCityId { get; set; }
        public string ProvinceOrCityCode { get; set; }
        public string ProvinceOrCityName { get; set; }
        public Guid? DistrictId { get; set; }
        public string DistrictCode { get; set; }
        public string DistrictName { get; set; }
        public Guid? WardOrCommuneId { get; set; }
        public string WardOrCommuneCode { get; set; }
        public string WardOrCommuneName { get; set; }
        public string Address { get; set; }
        public Guid? CareerId { get; set; }
        public string CareerCode { get; set; }
        public string CareerName { get; set; }
        public string WorkPlace { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string IdentificationNumber { get; set; }
        public DateTime? IssueDate { get; set; }
        public string IssueBy { get; set; }

        public string Description { get; set; }
    }
}
