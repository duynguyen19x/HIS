using AutoMapper.Configuration.Annotations;
using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Bệnh nhân.
    /// </summary>
    public class Patient : FullAuditedEntity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public int BirthYear { get; set; }
        public string BirthPlace { get; set; }
        public Guid GenderId { get; set; }
        public Guid EthnicId { get; set; }
        public Guid? BloodTypeId { get; set; }
        public Guid? BloodTypeRhId { get; set; }
        public Guid? CountryId { get; set; }
        public Guid? ProvinceOrCityId { get; set; }
        public Guid? DistrictId { get; set; }
        public Guid? WardOrCommuneId { get; set; }
        public string Address { get; set; }
        public Guid CareerId { get; set; }
        public string WorkPlace { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Phone { get; set; }
        public string IdentificationNumber { get; set; }
        public DateTime? IssueDate { get; set; }
        public string IssueBy { get; set; }
        public string Description { get; set; }

        [Ignore]
        public Gender Gender { get; set; }

        [Ignore]
        public Ethnic Ethnic { get; set; }

        [Ignore]
        public BloodType BloodType { get; set; }

        [Ignore]
        public BloodTypeRh BloodTypeRh { get; set; }

        [Ignore]
        public Country Country { get; set; }

        [Ignore]
        public Province Province { get; set; }

        [Ignore]
        public District District { get; set; }

        [Ignore]
        public SWard Ward { get; set; }

        [Ignore]
        public Career Career { get; set; }
    }
}
