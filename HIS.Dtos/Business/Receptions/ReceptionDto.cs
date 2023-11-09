using HIS.Application.Core.Services.Dto;
using HIS.Core.Enums;
using HIS.Dtos.Business.MedicalRecords;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.Receptions
{
    public class ReceptionDto : EntityDto<Guid>
    {
        public virtual Guid? PatientRecordId { get; set; } // id bệnh án
        public virtual string PatientRecordCode { get; set; } // mã bệnh án
        public virtual Guid? PatientId { get; set; } // id bệnh nhân
        public virtual string PatientCode { get; set; } // mã bệnh nhân
        public virtual string PatientName { get; set; } // tên bệnh nhân
        public virtual DateTime? BirthDate { get; set; } // ngày sinh
        public virtual int BirthYear { get; set; } // năm sinh
        public virtual string BirthPlace { get; set; } // nơi sinh
        public virtual Guid GenderId { get; set; } // giới tính
        public virtual Guid EthnicId { get; set; } // dân tộc
        public virtual Guid? CountryId { get; set; } // quốc tịch
        public virtual Guid? ProvinceId { get; set; } // tỉnh, thành phố
        public virtual Guid? DistrictId { get; set; } // huyện, quận
        public virtual Guid? WardId { get; set; } // xã, phường
        public virtual string Address { get; set; } // địa chỉ (số nhà, thôn, xóm, ....)
        public virtual Guid CareerId { get; set; } // nghề nghiệp
        public virtual string WorkPlace { get; set; } // nơi làm việc
        public virtual string Email { get; set; } // email
        public virtual string Tel { get; set; } // điện thoại cố định
        public virtual string Mobile { get; set; } // điện thoại di động
        public virtual string IdentificationNumber { get; set; } // số CMND, CCCD, hộ chiếu
        public virtual DateTime? IssueDate { get; set; } // ngày cấp
        public virtual string IssueBy { get; set; } // nơi cấp

        public virtual Guid? RalativeTypeId { get; set; } // mối quan hệ với bệnh nhân
        public virtual string RelativeName { get; set; } // tên người nhà
        public virtual string RelativeAddress { get; set; } // địa chỉ người nhà
        public virtual string RelativeTel { get; set; } // số điện thoại cố định người nhà
        public virtual string RelativeMobile { get; set; } // số điện thoại di động người nhà
        public virtual string RelativeIdentificationNumber { get; set; } // số CMND, CCCD người nhà
        public virtual DateTime? RelativeIssueDate { get; set; } // ngày cấp
        public virtual string RelativeIssueBy { get; set; } // nơi cấp

        // đăng ký khám
        public virtual DateTime ReceptionDate { get; set; } // ngày đăng ký
        public virtual Guid ReceptionDepartmentId { get; set; } // khoa đăng ký
        public virtual Guid ReceptionRoomId { get; set; } // phòng đăng ký
        public virtual int ReceptionType { get; set; } // loại đăng ký (cskh, phòng đón tiếp, ....)
        public virtual int ReceptionObjectType { get; set; } // đối tượng đăng ký khám (khám bệnh, cấp cứu, ....)
        public virtual string HospitalizationReason { get; set; } // lý do khám
        public virtual bool IsPriority { get; set; } // là ưu tiên
        public virtual bool IsEmergency { get; set; } // là cấp cứu
        public virtual int SortOrder { get; set; } // số thứ tự đến khám
        public string Description { get; set; } // ghi chú

        public virtual Guid ServiceId { get; set; } // dịch vụ
        public virtual Guid RequestUserId { get; set; } // người chỉ định
        public virtual Guid RequestBranchId { get; set; } // chi nhánh chỉ định
        public virtual Guid RequestDepartmentId { get; set; } // khoa chi định
        public virtual Guid RequestRoomId { get; set; } // phòng chỉ định
        public virtual Guid ExecuteBranchId { get; set; } // chi nhánh thực hiện
        public virtual Guid ExecuteDepartmentId { get; set; } // khoa thực hiện
        public virtual Guid ExecuteRoomId { get; set; } // phòng thực hiện

        // giấy giới thiệu (thông tin chuyển tuyến đến)




        public ReceptionDto() 
        {
            
        }
    }
}
