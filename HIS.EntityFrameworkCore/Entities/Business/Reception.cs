using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Thông tin tiếp đón.
    /// </summary>
    public class Reception : FullAuditedEntity<Guid>
    {
        public Guid MedicalRecordID { get; set; } // bệnh án
        public Guid TreatmentID { get; set; } // điều trị, khám bệnh
        public Guid BranchID { get; set; } // chi nhánh
        public Guid DepartmentID { get; set; } // khoa đăng ký
        public Guid RoomID { get; set; } // phòng đăng ký
        public Guid UserID { get; set; } // nhân viên đăng ký
        public Guid ExecuteDepartmentID { get; set; } // khoa thực hiện (khoa khám bệnh)
        public Guid ExecuteRoomID { get; set; } // phòng thực hiện (phòng khám bệnh)
        public Guid? ExecuteUserID { get; set; } // bác sỹ khám
        public Guid? ServiceID { get; set; } // dịch vụ khám

        public int PatientTypeID { get; set; } // đối tượng bệnh nhân (bhyt, viện phí, dịch vụ, ...)
        public int ReceptionTypeID { get; set; } // đối tượng tiếp đón (khám bệnh, cấp cứu)
        public DateTime ReceptionDate { get; set; } // ngày tiếp đóm
        public bool IsPriority { get; set; } // bệnh nhân ưu tiên
        public string HospitalizationReason { get; set; } // lý do khám
        public int SortOrder { get; set; } // số thứ tự khám (theo từng phòng thực hiện)
        public string Description { get; set; } // ghi chú

        public MedicalRecord MedicalRecord { get; set; }
        public Treatment Treatment { get; set; }
        public Branch Branch { get; set; }
        public Department Department { get; set; }
        public Room Room { get; set; }
        public User User { get; set; }
        public Department ExecuteDepartment { get; set; }
        public Room ExecuteRoom { get; set; }
        public User ExecuteUser { get; set; }
        public Service Service { get; set; }
        public PatientType PatientType { get; set; }
        public ReceptionType ReceptionType { get; set; }
    }
}
