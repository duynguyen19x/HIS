using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.PatientRecords
{
    public class PatientRecordDto : EntityDto<Guid>
    {
        public string PatientRecordCode { get; set; }
        public Guid PatientID { get; set; }
        public string PatientName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int BirthYear { get; set; }
        public string BirthPlace { get; set; }
        public Guid GenderID { get; set; }
        public Guid EthnicityID { get; set; }
        public Guid CountryID { get; set; }
        public Guid ProvinceOrCityID { get; set; }
        public Guid DistrictID { get; set; }
        public Guid WardOrCommuneID { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public Guid CareerID { get; set; }
        public string WorkPlace { get; set; }
        public string IdentificationNumber { get; set; }
        public DateTime? IssueDate { get; set; }
        public string IssueBy { get; set; }
        public string Description { get; set; }



    }
}
