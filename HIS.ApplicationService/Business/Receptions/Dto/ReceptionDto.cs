using HIS.ApplicationService.Business.MedicalRecords.Dto;
using HIS.ApplicationService.Business.PatientRecords.Dto;
using HIS.Core.Application.Services.Dto;
using HIS.EntityFrameworkCore.Entities.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Receptions.Dto
{
    public class ReceptionDto : EntityDto<Guid?>
    {
        public virtual Guid? PatientId { get; set; }

        public virtual Guid? PatientRecordId { get; set; }

        public virtual Guid? MedicalRecordId { get; set; }

        public virtual string PatientCode { get; set; }

        public virtual string PatientName { get; set; }

        public virtual string PatientRecordCode { get; set; }

        public virtual string MedicalRecordCode { get; set; }

        public virtual DateTime ReceptionDate { get; set; }

        public virtual int ReceptionObjectTypeId { get; set; } // loại đăng ký khám

        public virtual string ReceptionObjectTypeName { get; set; }

        public virtual int PatientObjectTypeId { get; set; }

        public virtual string PatientObjectTypeName { get; set; }

        public virtual string HospitalizationReason { get; set; }

        public virtual string Description { get; set; }

        public virtual Guid BranchId { get; set; }

        public virtual string BranchName { get; set; }

        public virtual Guid DepartmentId { get; set; }

        public virtual string DepartmentName { get; set; }

        public virtual Guid RoomId { get; set; }

        public virtual string RoomName { get; set; }

        public virtual int Gate { get; set; }

        public virtual Guid UserId { get; set; } // nhân viên đăng ký

        public virtual string UserName { get; set; }

        public virtual Guid? ServiceId { get; set; } // dịch vụ

        public virtual string ServiceName { get; set; }

        public virtual Guid? ExecuteDepartmentId { get; set; } // khoa thực hiện dịch vụ

        public virtual string ExecuteDepartmentName { get; set; } // khoa thực hiện dịch vụ

        public virtual Guid? ExecuteRoomId { get; set; } // phòng thực hiện dịch vụ

        public virtual string ExecuteRoomName { get; set; } // phòng thực hiện dịch vụ

        public virtual Guid? ExecuteUserId { get; set; }

        public virtual string ExecuteUserName { get; set; }

        public PatientRecordDto PatientRecord { get; set; }

        public MedicalRecordDto MedicalRecord { get; set; }
    }
}
