using HIS.Core.Entities.Auditing;
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
        public Guid? GenderID { get; set; }
        public Guid? EthnicityID { get; set; }
        public Guid? ReligionID { get; set; }
        public Guid? CountryID { get; set; }
        public Guid? ProvinceID { get; set; }
        public Guid? DistrictID { get; set; }
        public Guid? WardID { get; set; }
        public string Address { get; set; }
        public Guid? CareerID { get; set; }
        public string Workplace { get; set; }
        public string IdentificationNumber { get; set; }
        public DateTime? IssueDate { get; set; }
        public string IssueBy { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        
        public Patient() { }
    }
}
