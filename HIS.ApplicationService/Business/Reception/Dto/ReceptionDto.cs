using HIS.ApplicationService.Business.MedicalRecords.Dto;
using HIS.ApplicationService.Business.PatientRecords.Dto;
using HIS.Core.Application.Services.Dto;
using HIS.EntityFrameworkCore.Entities.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Reception.Dto
{
    public class ReceptionDto : EntityDto<Guid>
    {
        public Guid? PatientId { get; set; }
        public string PatientCode { get; set; }
        public string PatientName { get; set; }
        public Guid? PatientRecordId { get; set; }
        public string PatientRecordCode { get; set; }
        public long? BirthDate { get; set; }
        public int BirthYear { get; set; }
        public string BirthPlace { get; set; }
        public string Age { get; set; }
        public Guid GenderId { get; set; }
        public string GenderName { get; set; }
        public Guid EthnicityId { get; set; }
        public string EthnicityName { get; set; }
        public Guid? CountryId { get; set; }
        public string CountryName { get; set; }

        public int PatientObjectTypeId { get; set; } // đối tượng bệnh nhân
        public int ReceptionObjectTypeId { get; set; } // đối tượng tiếp đón (khám bệnh, cấp cứu)
        public string HospitalizationReason { get; set; } // lý do khám
        public bool IsPriority { get; set; } // là ưu tiên

        public PatientRecordDto PatientRecord { get; set; }
        public MedicalRecordDto MedicalRecord { get; set; }
    }
}
