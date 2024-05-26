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

        public Guid? PatientId { get; set; }
        public Guid? MedicalRecordId { get; set; }
        public Guid? TreatmentId { get; set; }
        public Guid UserId { get; set; } // nhân viên
        public Guid BranchId { get; set; } // chi nhánh làm việc
        public Guid DepartmentId { get; set; } // khoa 
        public Guid RoomId { get; set; } // phòng 
        public string Gate { get; set; } // số cửa tiếp đón
        public int ReceptionObjectTypeId { get; set; } // đối tượng đăng ký khám
        public int PatientObjectTypeId { get; set; } // đối tượng bệnh nhân
        public string ChiefComplaint { get; set; } // lý do đến khám
        public string Description { get; set; } // ghi chú tiếp đón

        public string PatientCode { get; set; }
        public string PatientName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int BirthYear { get; set; }
        public string GenderName { get; set; }
        public string Address { get; set; }

        //public Guid? ServiceId { get; set; } // dịch vụ khám
        //public string ServiceName { get; set; } // tên dịch vụ khám
        //public Guid? ExecuteDepartmentId { get; set; } // khoa thực hiện
        //public Guid? ExecuteRoomId { get; set; } // phòng thực hiện
        //public Guid? ExecuteUserId { get; set; } // người thực hiện

        public MedicalRecordDto MedicalRecord { get; set; }
        public TreatmentDto Treatment { get; set; }

        public ReceptionServiceDto ReceptionServices { get; set; } // danh sách dịch vụ khám đăng ký

        public ReceptionDto() 
        {
            ReceptionDate = DateTime.Now;

            MedicalRecord = new MedicalRecordDto();
            Treatment = new TreatmentDto();
        }
    }
}
