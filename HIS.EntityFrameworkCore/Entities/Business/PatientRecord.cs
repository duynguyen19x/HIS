using AutoMapper.Configuration.Annotations;
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
    /// Hồ sơ bệnh án.
    /// </summary>
    public class PatientRecord : FullAuditedEntity<Guid>
    {
        public Guid PatientId { get; set; }
        public string PatientRecordCode { get; set; } // số hồ sơ bệnh án 
        public DateTime PatientRecordDate { get; set; } // thời gian vào viện (thời gian đăng ký)
        public int PatientRecordStatusId { get; set; } // trạng thái (0: mới tạo. 100: đang khám, điều trị. 200: đã kết thúc khám, điều trị. 300: đã thu tiền, khóa viện phí, 400: đã duyệt bhyt. trong các nhóm trạng thái chính sẽ phát sinh các trạng thái phụ khác, vd mở bệnh án, ....)
        public Guid BranchId { get; set; } // chi nhánh khám, chứa bệnh
        public Guid DepartmentId { get; set; } // khoa tiếp đón
        public Guid RoomId { get; set; } // phòng tiếp đón
        public Guid UserId { get; set; } // người tạo (nhân viên tiếp đón)
        public int PatientTypeId { get; set; } // đối tượng bệnh nhân
        public int ReceptionObjectTypeId { get; set; } // đối tượng tiếp đón (khám bệnh, cấp cứu)
        public string HospitalizationReason { get; set; } // lý do khám
        public bool IsPriority { get; set; } // là ưu tiên

        public string PatientName { get; set; } 
        public DateTime? BirthDate { get; set; }
        public int BirthYear { get; set; }
        public string Birthplace { get; set; }
        public Guid? GenderId { get; set; }
        public Guid? EthnicId { get; set; }
        public Guid? ReligionId { get; set; }
        public Guid? NationalId { get; set; }
        public Guid? ProvinceId { get; set; }
        public Guid? DistrictId { get; set; }
        public Guid? WardId { get; set; }
        public string Address { get; set; }
        public Guid? CareerId { get; set; }
        public string Workplace { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string IdentificationNumber { get; set; }
        public DateTime? IssueDate { get; set; }
        public string IssueBy { get; set; }

        public Guid? RelativeTypeId { get; set; } // mối quan hệ với bệnh nhân
        public string RelativeName { get; set; } // người nhà bệnh nhân
        public string RelativeAddress { get; set; }
        public string RelativeTel { get; set; }
        public string RelativeMobile { get; set; }
        public string RelativeIdentificationNumber { get; set; }
        public DateTime? RelativeIssueDate { get; set; }
        public string RelativeIssueBy { get; set; }

        public Guid? InsuranceId { get; set; } // thông tin bảo hiểm y tế

        public bool IsTransferIn { get; set; } // là bệnh nhân chuyển viện đến
        public string TransferInCode { get; set; } // số chuyển viện
        public string TransferInMediOrgCode { get; set; } // mã nơi chuyển đến
        public string TransferInMediOrgName { get; set; } // tên nơi chuyển đến
        public DateTime? TransferInTimeFrom { get; set; } // khám bệnh, điều trị từ ngày
        public DateTime? TransferInTimeTo { get; set; } // đến ngày
        public string TransferInIcdCode { get; set; } // chẩn đoán của nơi chuyển đến
        public string TransferInIcdName { get; set; } // tên chẩn đoán của nơi chuyển đến
        public Guid? TransferInFormID { get; set; } // hình thức chuyển viện
        public Guid? TransferInReasonID { get; set; } // lý do chuyển viện
        public bool TransferInRightRoute { get; set; } // chuyển đúng tuyến CMKT
        public bool TransferInOverRoute { get; set; } // chuyển vượt tuyến CMKT

        // thông tin khám bệnh và điều trị
        public DateTime? ClinicalTime { get; set; } // thời bắt đầu gian khám
        public Guid? ClinicalDepartmentID { get; set; } // khoa khám bệnh
        public Guid? ClinicalRoomID { get; set; } // phòng khám
        public Guid? ClinicalUserID { get; set; } // bác sỹ khám bệnh


        public DateTime? InTime { get; set; } // thời gian nhập viện
        public string InCode { get; set; } // số vào viện
        public Guid? InDepartmentID { get; set; } // khoa nhập viện
        public Guid? InRoomID { get; set; } // phòng nhập viện
        public Guid? InUserID { get; set; } // người tiếp nhận
        public string InIcdCode { get; set; } 
        public string InIcdName { get; set; }
        public string InIcdSubCode { get; set; }
        public string InIcdText { get; set; }


        public DateTime? OutTime { get; set; } // thời gian kết thúc điều trị, khám bệnh
        public Guid? OutDepartmentID { get; set; } // khoa kết thúc
        public Guid? OutRoomID { get; set; } // phòng kết thúc
        public Guid? OutUserID { get; set; } // bác sỹ

        #region IV. tình trạng ra viện

        public int TreatmentResultTypeID { get; set; } // kết quả điều trị
        public int TreatmentEndTypeID { get; set; } // hình thức xử trí
        public string OutIcdCode { get; set; } // bệnh chính
        public string OutIcdName { get; set; } // tên bệnh chính
        public string OutIcdSubCode { get; set; } // bệnh kèm theo
        public string OutIcdText { get; set; } // tên bệnh kèm theo
        public string OutIcdCauseCode { get; set; } // nguyên nhân
        public string OutIcdCauseName { get; set; } // tên nguyên nhân
        public string TreatmentDirection { get; set; } // hướng điều trị tiếp theo
        public string TreatmentMethod { get; set; } // phương pháp điều trị
        public string Advise { get; set; } // lời dặn bác sỹ

        public DateTime? AppointmentTime { get; set; } // thời gian hẹn khám

        public DateTime? TransferTime { get; set; }
        public int TransferTypeID { get; set; } // chuyển tuyến: khám bệnh, điều trị
        public string TransferMediOrgCode { get; set; }
        public string TransferMediOrgName { get; set; }
        public string Transporter {  get; set; } // người vận chuyển
        public string TransportVehicle {  get; set; } // phương tiện vận chuyển
        public Guid? TransferFormID { get; set; } // hình thức chuyển viện
        public Guid? TransferReasonID { get; set; } //lý do chuyển viện
        public bool TransferRouteRight { get; set; } // chuyển đúng tuyến CMKT
        public bool TransferRouteOver { get; set; } // chuyển vượt tuyến CMKT

        public DateTime? DeathTime { get; set; } // thời điểm tử vong
        public Guid? DeathCertBookID { get; set; } // sổ giấy tử vong
        public int DeathCertNum { get; set; } // số tử vong
        public Guid? DeathWithinID { get; set; } // thời gian tử vong
        public Guid? DeathCauseID { get; set; } // nguyên nhân tử vong
        public bool IsHasAutopsy { get; set; } // có khám nghiệm tử thi
        public string AutopsyIcdCode { get; set; } // chẩn đoán giải phẫu tử thi
        public string AutopsyIcdName { get; set; } // tên chẩn đoán giải phẫu tử thi

        #endregion

        #region lưu trữ
        public DateTime? StoreTime { get; set; }
        public string StoreCode { get; set; }
        #endregion

        [Ignore]
        public Gender Gender { get; set; }
        [Ignore]
        public Ethnic Ethnic { get; set; }
        [Ignore]
        public Religion Religion { get; set; }
        [Ignore]
        public National National { get; set; }
        [Ignore]
        public Province Province { get; set; }
        [Ignore]
        public District District { get; set; }
        [Ignore]
        public Ward Ward { get; set; }
        [Ignore]
        public Career Career { get; set; }
    }
}
