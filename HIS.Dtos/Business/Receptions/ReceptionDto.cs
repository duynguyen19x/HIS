﻿using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Business.MedicalRecords;
using HIS.Dtos.Business.Treatments;

namespace HIS.Dtos.Business.Receptions
{
    /// <summary>
    /// Dữ liệu cho chức năng tiếp đón
    /// </summary>
    public class ReceptionDto : EntityDto<Guid>
    {
        public Guid PatientID { get; set; } // bệnh nhân
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

        public string PatientCode { get; set; }
        public string MedicalRecordCode { get; set; }
        public string PatientName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int BirthYear { get; set; }
        public string GenderName { get; set; }
        public string Address { get; set; }
        public string DepartmentName { get; set; }
        public string RoomName { get; set; }
        public string UserName { get; set; }
        public string ExecuteDepartmentName { get; set; }
        public string ExecuteRoomName { get; set; }
        public string ExecuteUserName { get; set; }
        public string ServiceName { get; set; }
        public int PatientTypeID { get; set; } // đối tượng bệnh nhân (bhyt, viện phí, dịch vụ, ...)
        public int ReceptionTypeID { get; set; } // đối tượng tiếp đón (khám bệnh, cấp cứu)
        public DateTime ReceptionDate { get; set; } // ngày tiếp đóm
        public bool IsPriority { get; set; } // bệnh nhân ưu tiênn
        public string HospitalizationReason { get; set; } // lý do khám
        public int SortOrder { get; set; } // số thứ tự khám (theo từng phòng thực hiện)
        public string Description { get; set; } // ghi chú

        public MedicalRecordDto MedicalRecord { get; set; }
        public TreatmentDto Treatment { get; set; }
    }
}
