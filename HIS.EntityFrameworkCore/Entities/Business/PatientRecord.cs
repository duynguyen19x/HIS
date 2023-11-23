using AutoMapper.Configuration.Annotations;
using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    public class PatientRecord : FullAuditedEntity<Guid>
    {
        public string PatientRecordCode { get; set; } // mã điều trị
        public Guid PatientID { get; set; }
        public string PatientName { get; set; } // tên bệnh nhân (mỗi lần đăng ký khám có thể tên khác nhau)
        public DateTime? BirthDate { get; set; } // ngày sinh (không bắt buộc)
        public int BirthYear { get; set; } // năm sinh (bắt buộc)
        public string BirthPlace { get; set; } // nơi sinh
        public Guid GenderID { get; set; } // giới tính
        public Guid CountryID { get; set; } // quốc tịch
        public Guid ProvinceOrCityID { get; set; } // tỉnh, thành phố
        public Guid DistrictID { get; set; } // quận, huyện
        public Guid WardOrCommuneID { get; set; } // xã, phường
        public string Address { get; set; } // địa chỉ (số nhà, thôn, xóm,....)
        public string Email { get; set; } // email
        public string Tel { get; set; } // điện thoại cố định
        public string Mobile { get; set; } // điện thaoij di động
        public Guid CareerID { get; set; } // nghề nghiệp
        public string WorkPlace { get; set; } // nơi làm việc
        public Guid EthnicityID { get; set; } // dân tộc
        public string IdentificationNumber { get; set; } // số CMND/CCCD
        public DateTime? IssueDate { get; set; } // ngày cấp
        public string IssueBy { get; set; } // nơi cấp

        // người nhà
        public Guid? RalativeTypeId { get; set; } // mối quan hệ với bệnh nhân
        public string RelativeName { get; set; } // tên người nhà
        public string RelativeAddress { get; set; } // địa chỉ người nhà
        public string RelativeTel { get; set; } // số điện thoại cố định người nhà
        public string RelativeMobile { get; set; } // số điện thoại di động người nhà
        public string RelativeIdentificationNumber { get; set; } // số CMND, CCCD người nhà
        public DateTime? RelativeIssueDate { get; set; } // ngày cấp
        public string RelativeIssueBy { get; set; } // nơi cấp

        // bệnh nhân
        public int PatientObjectTypeID { get; set; } // đối tượng bệnh nhân (viện phí, dịch vụ, BHYT, ....)

        // thông tin đăng ký
        public int ReceptionObjectTypeID { get; set; } // loại đối tượng đăng ký khám (khám bệnh, cấp cứu)
        public DateTime ReceptionDate { get; set; } // ngày đăng ký
        public string HospitalizationReason { get; set; } // lý do khám
        public Guid ReceptionDepartmentID { get; set; } // khoa đăng ký
        public Guid ReceptionRoomID { get; set; } // phòng đăng ký
        public bool IsPriority { get; set; } // bệnh nhân ưu tiên
        public int SortOrder { get; set; } // số thứ tự đến khám
        public string Description { get; set; } // ghi chú

        [Ignore]
        public virtual Patient Patient { get; set; }

        public PatientRecord()
        {

        }
    }
}
