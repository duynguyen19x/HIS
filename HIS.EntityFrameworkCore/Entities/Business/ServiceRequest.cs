using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Phiếu chỉ định dịch vụ.
    /// </summary>
    public class ServiceRequest : FullAuditedEntity<Guid>
    {
        public virtual string Code { get; set; }
        public virtual string GroupCode { get; set; }
        public virtual int SortOrder { get; set; } // số thứ tự
        public virtual bool IsPriority { get; set; } // là ưu tiên
        public virtual bool IsEmergency { get; set; } // là cấp cứu
        public virtual string Barcode { get; set; }
        public virtual string Description { get; set; }
        public virtual int Status { get; set; } // trạng thái thực hiện dịch vụ
        //public virtual int ServiceRequestTypeId { get; set; }

        public virtual Guid PatientId { get; set; } // mã bệnh nhân
        public virtual Guid PatientRecordId { get; set; } // mã điều trị
        public virtual Guid MedicalRecordId { get; set; } // mã bệnh án
        public virtual Guid TreatmentId { get; set; } // mã phiếu điều trị
        public virtual Guid BranchId { get; set; } // chi nhánh

        public virtual DateTime RequestTime { get; set; } // thời gian chỉ định 
        public virtual Guid RequestRoomId { get; set; } // phòng chỉ định
        public virtual Guid RequestDepartmentId { get; set; } // khoa chỉ định
        public virtual Guid RequestUserId { get; set; }
        public virtual string RequestUsername { get; set; } // tên người chỉ định
        public virtual Guid? ExecuteRoomId { get; set; } // phòng thực hiện
        public virtual Guid? ExecuteDepartmentId { get; set; } // khoa thực hiện
        public virtual Guid? ExecuteUserId { get; set; }
        public virtual string ExecuteUsername { get; set; } // tên người chỉ định
        public virtual DateTime? ExecuteStartTime { get; set; } // thời gian bắt đầu thực hiện
        public virtual DateTime? ExecuteEndTime { get; set; } // thời gian kết thúc thực hiện
        public virtual Guid? SampleRoomId { get; set; } // phòng lấy mẫu
        public virtual string IcdCode { get; set; } // mã bệnh chính
        public virtual string IcdName { get; set; } // tên bệnh chính
        public virtual string IcdSubCode { get; set; } // mã bệnh phụ
        public virtual string IcdSubName { get; set; } // tên bệnh phụ
        public virtual string IcdText { get; set; }
        public virtual string IcdCauseCode { get; set; } // mã bệnh nguyên nhân
        public virtual string IcdCauseName { get; set; } // tên mã bệnh nguyên nhân

        public ServiceRequest() { }
    }
}
