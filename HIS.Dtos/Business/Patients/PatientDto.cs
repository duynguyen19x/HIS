﻿using HIS.Core.Services.Dto;

namespace HIS.Dtos.Business.Patients
{
    public class PatientDto : EntityDto<Guid>
    {
        public string PatientCode { get; set; }
        public string PatientName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int BirthYear { get; set; }
        public string Birthplace { get; set; }
        public Guid? GenderId { get; set; }
        public Guid? EthnicId { get; set; }
        public Guid? ReligionId { get; set; }
        public Guid? CountryId { get; set; }
        public Guid? ProvinceId { get; set; }
        public Guid? DistrictId { get; set; }
        public Guid? WardId { get; set; }
        public string Address { get; set; }
        public Guid? CareerId { get; set; }
        public string Workplace { get; set; }
        public string IdentificationNumber { get; set; }
        public DateTime? IssueDate { get; set; }
        public string IssueBy { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
    }
}
