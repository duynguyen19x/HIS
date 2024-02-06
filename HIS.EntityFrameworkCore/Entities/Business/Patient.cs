using AutoMapper.Configuration.Annotations;
using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    public class Patient : FullAuditedEntity<Guid>
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

        [Ignore]
        public DIGender Gender { get; set; }
        [Ignore]
        public DIEthnicity Ethnic { get; set; }
        [Ignore]
        public DIReligion Religion { get; set; }
        [Ignore]
        public DICountry National { get; set; }
        [Ignore]
        public DIProvince Province { get; set; }
        [Ignore]
        public DIDistrict District { get; set; }
        [Ignore]
        public DIWard Ward { get; set; }
        [Ignore]
        public DICareer Career { get; set; }

        public Patient() { }
    }
}
