using HIS.ApplicationService.Business.MedicalRecords.Dto;
using HIS.ApplicationService.Business.Treatments.Dto;
using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Receptions.Dto
{
    public class ReceptionDto : EntityDto<Guid>
    {
        public DateTime ReceptionDate { get; set; }

        public Guid PatientID { get; set; }
        public Guid MedicalRecordID { get; set; }
        public Guid TreatmentID { get; set; }
        public Guid UserID { get; set; }
        public Guid BranchID { get; set; }
        public Guid DepartmentID { get; set; }
        public Guid RoomID { get; set; } // phòng tiếp đón
        public string Gate { get; set; } // cửa
        public int ReceptionObjectTypeID { get; set; } // đối tượng đăng ký khám
        public int PatientObjectTypeID { get; set; } // đối tượng bệnh nhân
        public string ChiefComplaint { get; set; } // lý do đến khám
        public string Description { get; set; } // ghi chú tiếp đón

        public Guid? ServiceID { get; set; } // dịch vụ khám
        public string ServiceName { get; set; } // tên dịch vụ khám
        public Guid? ExecuteDepartmentID { get; set; } // khoa thực hiện
        public Guid? ExecuteRoomID { get; set; } // phòng thực hiện
        public Guid? ExecuteUserID { get; set; } // người thực hiện

        public MedicalRecordDto MedicalRecord { get; set; }
        public TreatmentDto Treatment { get; set; }

        public ReceptionDto() 
        {
            ReceptionDate = DateTime.Now;

            MedicalRecord = new MedicalRecordDto();
            Treatment = new TreatmentDto();
        }
    }
}
