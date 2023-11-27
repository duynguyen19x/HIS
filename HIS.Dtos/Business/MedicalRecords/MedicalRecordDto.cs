using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Business.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.MedicalRecords
{
    /// <summary>
    /// Hồ sơ bệnh án.
    /// </summary>
    public class MedicalRecordDto : EntityDto<Guid>
    {
        public string MedicalRecordCode { get; set; }
        public DateTime MedicalRecordDate { get; set; }
        public int MedicalRecordStatusID { get; set; }  // 0: NEW, 1: OPEN, 3: CLOSE, 2: STORE
        public Guid PatientID { get; set; }
        public string PatientName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int BirthYear { get; set; }
        public string Birthplace { get; set; }
        public Guid? GenderID { get; set; }
        public Guid? EthnicityID { get; set; }
        public Guid? ReligionID { get; set; }
        public Guid? CountryID { get; set; }
        public Guid? ProvinceOrCityID { get; set; }
        public Guid? DistrictID { get; set; }
        public Guid? WardID { get; set; }
        public Guid? CareerID { get; set; }
        public string Workplace { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        public int PatientTypeID { get; set; } // loại đối tượng khám bệnh
        public int ReceptionTypeID { get; set; } // loại đối tượng đăng ký khám
        public string HospitalizationReason { get; set; } // lý do khám
        public string Description { get; set; } // ghi chú
        public bool IsPriority { get; set; } // là bệnh nhân ưu tiên



        public PatientDto Patient { get; set; }
    }
}
