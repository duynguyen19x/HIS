using AutoMapper.Configuration.Annotations;
using HIS.Core.Entities.Auditing;
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
        
        public Guid BranchID { get; set; } // mã chi nhánh
        public int PatientTypeID { get; set; } // đối tượng bệnh nhân (viện phí, dịch vụ, bhyt, ....)
        public int PatientRecordTypeID { get; set; } // loại hồ sơ bệnh án (nội trú, ngoại trú, dịch vụ, ....)
        public string PatientRecordCode { get; set; } // mã điều trị
        public DateTime PatientRecordDate { get; set; } // ngày bắt đầu đợt điều trị
        public string Description { get; set; } // ghi chú

        // hành chính
        public Guid PatientID { get; set; } // mã bệnh nhân
        public string PatientName { get; set; } // tên bệnh nhân (mỗi lần đăng ký khám có thể tên khác nhau)
        public DateTime? BirthDate { get; set; } // ngày sinh (không bắt buộc)
        public int BirthYear { get; set; } // năm sinh (bắt buộc)
        public string BirthPlace { get; set; } // nơi sinh
        public Guid? GenderID { get; set; } // giới tính
        public Guid? CountryID { get; set; } // quốc tịch
        public Guid? ProvinceOrCityID { get; set; } // tỉnh, thành phố
        public Guid? DistrictID { get; set; } // quận, huyện
        public Guid? WardOrCommuneID { get; set; } // xã, phường
        public string Address { get; set; } // địa chỉ (số nhà, thôn, xóm,....)
        public string Email { get; set; } // email
        public string Tel { get; set; } // điện thoại cố định
        public string Mobile { get; set; } // điện thaoij di động
        public Guid? CareerID { get; set; } // nghề nghiệp
        public string WorkPlace { get; set; } // nơi làm việc
        public Guid? EthnicityID { get; set; } // dân tộc
        public Guid? ReligionID { get; set; } // tôn giáo
        public string IdentificationNumber { get; set; } // số CMND/CCCD
        public DateTime? IssueDate { get; set; } // ngày cấp
        public string IssueBy { get; set; } // nơi cấp

        // người nhà
        public Guid? RalativeTypeID { get; set; } // mối quan hệ với bệnh nhân
        public string RelativeName { get; set; } // tên người nhà
        public string RelativeAddress { get; set; } // địa chỉ người nhà
        public string RelativeTel { get; set; } // số điện thoại cố định người nhà
        public string RelativeMobile { get; set; } // số điện thoại di động người nhà
        public string RelativeIdentificationNumber { get; set; } // số CMND, CCCD người nhà
        public DateTime? RelativeIssueDate { get; set; } // ngày cấp
        public string RelativeIssueBy { get; set; } // nơi cấp

        // thông tin đăng ký
        public int ReceptionTypeID { get; set; } // loại đối tượng đăng ký khám (khám bệnh, cấp cứu)
        public DateTime ReceptionDate { get; set; } // ngày đăng ký
        public string HospitalizationReason { get; set; } // lý do khám
        public Guid ReceptionDepartmentID { get; set; } // khoa đăng ký
        public Guid ReceptionRoomID { get; set; } // phòng đăng ký
        public bool IsPriority { get; set; } // bệnh nhân ưu tiên
        public int SortOrder { get; set; } // số thứ tự đến khám
        public string ReceptionDescription { get; set; } // ghi chú tiếp đón

        public bool IsTransferIn { get; set; } // là bệnh nhân chuyển viện đến
        public DateTime? TransferInDate { get; set; } // ngày chuyển tuyến
        public string TransferInMediOrgCode { get; set; } // mã bệnh viện chuyển đến
        public string TransferInMediOrgName { get; set; } // tên bệnh viện chuyển đến
        public string TransferInCode { get; set; } // số giấy chuyển viện
        public string TransferInIcdCode { get; set; } // mã chẩn đoán bệnh viện chuyển đến
        public string TransferInIcdName { get; set; } // tên chẩn đoán bệnh viện chuyển đến
        public Guid? TransferInFormID { get; set; } // hình thức chuyển viện
        public Guid? TransferInReasonID { get; set; } // lý do chuyển viện
        public string TransferInDescription { get; set; } // ghi chú chuyển viện
        public bool DungTuyen { get; set; } // chuyển đúng tuyến
        public bool VuotTuyen { get; set; } // chuyển vượt tuyến
        public bool ChiKhamXetNghiem { get; set; } // chỉ khám, xét nghiệm (không điều trị)

        // thông tin viện phí
        public decimal TotalAmount { get; set; }
        public decimal TotalPatientAmount { get; set; }
        public decimal TotalBHYTAmount { get; set; }

        // khám bệnh
        public Guid? ExamDepartmentID { get; set; }
        public Guid? ExamRoomID { get; set; }
        public string ExamIcdCode { get; set; }
        public string ExamIcdName { get; set; }
        public string ExamIcdSubCode { get; set; }
        public string ExamIcdText { get; set; }

        // điều trị (nhập viện)


        // kết thúc điều trị

        [Ignore]
        public virtual Patient Patient { get; set; }

        public PatientRecord()
        {

        }
    }
}
