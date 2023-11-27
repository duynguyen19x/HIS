using AutoMapper.Configuration.Annotations;
using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Thông tin bệnh nhân.
    /// </summary>
    public class Patient : FullAuditedEntity<Guid>
    {
        public string PatientCode { get; set; }
        public string PatientName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int BirthYear { get; set; }
        public string Birthplace { get; set; }
        public Guid GenderID { get; set; }
        public Guid EthnicityID { get; set; }
        public Guid ReligionID { get; set; }
        public Guid CountryID { get; set; }
        public Guid ProvinceOrCityID { get; set; }
        public Guid DistrictID { get; set; }
        public Guid WardID { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public Guid CareerID { get; set; }
        public string Workplace { get; set; }
        public string IdentificationNumber { get; set; }
        public DateTime? IssueDate { get; set; }
        public string IssueBy { get; set; }
        public string Description { get; set; }
        public Guid? BloodTypeID { get; set; }
        public Guid? BloodTypeRhID { get; set; }

        [Ignore]
        public virtual Gender Gender { get; set; }
        [Ignore]
        public virtual Ethnicity Ethnicity { get; set; }
        [Ignore]
        public virtual Religion Religion { get; set; }
        [Ignore]
        public virtual Country Country { get; set; }
        [Ignore]
        public virtual Province ProvinceOrCity { get; set; }
        [Ignore]
        public virtual District District { get; set; }
        [Ignore]
        public virtual SWard WardOrCommune { get; set; }
        [Ignore]
        public virtual Career Career { get; set; }
        [Ignore]
        public virtual BloodType BloodType { get; set; }
        [Ignore]
        public virtual BloodTypeRh BloodTypeRh { get; set; }
        

        public Patient()
        {
        }
    }
}
