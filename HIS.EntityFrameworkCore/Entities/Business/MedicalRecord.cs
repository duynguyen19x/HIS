using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Bệnh án.
    /// </summary>
    public class MedicalRecord : FullAuditedEntity<Guid>
    {
        #region - hành chính

        public string MedicalRecordCode { get; set; }
        public DateTime MedicalRecordDate { get; set; }
        public int MedicalRecordStatusID { get; set; }  // 0: NEW, 1: OPEN, 3: CLOSE, 2: STORE
        public Guid PatientID { get; set; }
        public string PatientName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int BirthYear { get; set; }
        public string Birthplace { get; set; }
        public Guid? GenderID { get; set; } // giới tính
        public Guid? EthnicityID { get; set; } // dân tộc
        public Guid? ReligionID { get; set; } // tôn giáo
        public Guid? CountryID { get; set; } // quốc tịch
        public Guid? ProvinceOrCityID { get; set; } // tỉnh, thành phố
        public Guid? DistrictID { get; set; } // quận, huyện
        public Guid? WardID { get; set; } // xã, phường
        public string Address { get; set; } // số nhà, thôn, xóm
        public Guid? CareerID { get; set; }
        public string Workplace { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string IdentificationNumber { get; set; }
        public DateTime? IssueDate { get; set; }
        public string IssueBy { get; set; }

        #endregion

        #region - đón tiếp

        public int PatientTypeID { get; set; } // loại đối tượng khám bệnh
        public int ReceptionTypeID { get; set; } // loại đối tượng đăng ký khám
        public string HospitalizationReason { get; set; } // lý do khám (đăng ký)
        public string Description { get; set; } // ghi chú
        public bool IsPriority { get; set; } // là bệnh nhân ưu tiên

        public bool IsTransferIn { get; set; }
        public string TransferInCode { get; set; }
        public DateTime? TransferInDate { get; set; } // ngày chuyển
        public DateTime? TransferInTimeFrom { get; set; } // khám bệnh/ điều trị từ ngày
        public DateTime? TransferInTimeTo { get; set; } // khám bệnh/ điều trị đến ngày
        public string TransferInMediOrgCode { get; set; } // bệnh viện chuyển đến
        public string TransferInMediOrgName { get; set; } // tên bệnh viện chuyển đến
        public string TransferInIcdCode { get; set; } // chẩn đoán
        public string TransferInIcdName { get; set; } // tên chẩn đoán
        public Guid? TransferInFormID { get; set; } // hình thức chuyển viện
        public Guid? TransferInReasonID { get; set; } // lý do chuyển viện
        public string TransferInNote { get; set; } // ghi chú
        public bool TransferInRightRoute { get; set; } // đúng tuyến CMKT
        public bool TransferInOverRoute { get; set; } // vượt tuyến CMKT
        public bool IsNonTreatment { get; set; } // không điều trị (chỉ khám, xét nghiệm)

        #endregion

        #region - tình trạng ra viện

        public DateTime? OutTime { get; set; }
        public Guid? OutDepartmentID { get; set; }
        public Guid? OutRoomID { get; set; }
        public Guid? OutUserID { get; set; }
        public int TreatmentResultID { get; set; } // kết quả điều trị
        public int TreatmentEndTypeID { get; set; } // hình thức xử trí
        public string IcdCode { get; set; } // bệnh chính
        public string IcdName { get; set; } // tên bệnh chính
        public string IcdSubCode { get; set; } // danh sách bệnh kèm theo
        public string IcdText { get; set; } // danh sách bệnh kèm theo
        public string TraditionalIcdCode { get; set; } // bệnh chính YHCT
        public string TraditionalIcdName { get; set; } // tên bệnh chính YHCT
        public string TraditionalIcdSubCode { get; set; } // tên bệnh chính YHCT
        public string TraditionalIcdText { get; set; } // bệnh kèm theo YHCT
        
        public string ClinicalCourse { get; set; } // quá trình bệnh lý và diễn biến lâm sàng
        public string ParalinicalResult { get; set; } // tóm tắt kết quả cận lâm sàng có giá trị chuẩn đoán
        public string TreatmentDirection { get; set; } // hướng điều trị tiếp theo
        public string TreatmentMethod { get; set; } // phương pháp điều trị
        public string Advise { get; set; } // lời dặn của bác sĩ
        public string PatientCondition { get; set; } // tình trạng bệnh nhân

        public DateTime? AppointmentTime { get; set; } // hẹn khám

        public string TransferCode { get; set; } // số chuyển viện
        public Guid? TransferHospitalID { get; set; } // 
        public Guid? TransferFormID { get; set; }
        public Guid? TransferReasonID { get; set; }
        public string TransportVehicle { get; set; } // phương tiện vận chuyển
        public string Transporter { get; set; } // người vận chuyển

        public Guid DeathCertBookID { get; set; }
        public int DeathCertNum { get; set; } // so giay bao tu
        public DateTime? DeathTime { get; set; }
        public Guid? DeathCauseID { get; set; }
        public Guid? DeathWithinID { get; set; }
        public bool IsHasAutopsy { get; set; } // có khám nghiệm tử thi
        public string AutopsyIcdCode { get; set; }
        public string AutopsyIcdName { get; set; }
        public string AutopsyIcdSubCode { get; set; }
        public string AutopsyIcdText { get; set; }

        #endregion

        public MedicalRecord() { }
    }
}
