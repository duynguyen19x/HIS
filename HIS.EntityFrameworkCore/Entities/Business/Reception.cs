using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Entities;
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
    /// Thông tin tiếp đón.
    /// </summary>
    public class Reception : Entity<Guid>
    {
        public virtual Guid PatientId { get; set; }

        public virtual Guid PatientRecordId { get; set; }

        public virtual Guid MedicalRecordId { get; set; }

        public virtual DateTime ReceptionDate { get; set; }

        public virtual int ReceptionObjectTypeId { get; set; } // loại đăng ký khám

        public virtual int PatientObjectTypeId { get; set; }

        [MaxLength(512)]
        public virtual string HospitalizationReason { get; set; }

        [MaxLength(255)]
        public virtual string Description { get; set; }

        public virtual Guid BranchId { get; set; }

        public virtual Guid DepartmentId { get; set; }

        public virtual Guid RoomId { get; set; }

        public virtual int Gate { get; set; }

        public virtual Guid UserId { get; set; } // nhân viên đăng ký

        public virtual Guid? ServiceId { get; set; } // dịch vụ

        public virtual Guid? ExecuteDepartmentId { get; set; } // khoa thực hiện dịch vụ

        public virtual Guid? ExecuteRoomId { get; set; } // phòng thực hiện dịch vụ

        public virtual Guid? ExecuteUserId { get; set; }


    }
}
