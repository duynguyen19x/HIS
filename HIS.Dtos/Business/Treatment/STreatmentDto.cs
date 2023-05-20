using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.Treatment
{
    public class STreatmentDto
    {
        public Guid? Id { get; set; }
        public string Code { get; set; }
        public Guid? PatientId { get; set; }
        public string PatientCode { get; set; }
        public string PatientName { get; set; }
        public Guid PatientTypeId { get; set; }
        public DateTime? DOB { get; set; }
        public int Year { get; set; }
        public DateTime InTimeClinical { get; set; } // thời gian đến khám
        public DateTime? InTime { get; set; } // thời gian vào viện
        public DateTime? OutTime { get; set; } // thời gian ra viện
        public Guid GenderId { get; set; }
        public Guid? CareerId { get; set; }
        public Guid EthnicId { get; set; }
        public Guid CountryId { get; set; }
        public Guid? ProvinceId { get; set; }
        public Guid? DistrictId { get; set; }
        public Guid? WardId { get; set; }
        public string Address { get; set; }
        public string IdentificationNumber { get; set; }
        public string Mobile { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string RelativeName { get; set; }
        public string RelativeAddress { get; set; }
        public string RelativeIdentificationNumber { get; set; }
        public string RelativePhoneNumbar { get; set; }
    }
}
