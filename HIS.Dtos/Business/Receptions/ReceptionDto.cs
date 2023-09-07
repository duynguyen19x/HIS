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
    public class ReceptionDto : EntityDto
    {
        public virtual Guid PatientId { get; set; }
        public virtual string PatientCode { get; set; } // mã bệnh nhân
        public virtual string PatientName { get; set; } // tên bệnh nhân
        public virtual Guid PatientRecordId { get; set; }
        public virtual string PatientRecordCode { get; set; } // mã điều trị
        public virtual Guid UserId { get; set; } // người đăng ký
        public virtual Guid BranchId { get; set; } // chi nhánh đăng ký và khám chữa bệnh
        public virtual Guid DepartmentId { get; set; } // khoa đăng ký
        public virtual Guid RoomId { get; set; } // phòng đăng ký
        
        // thông tin hành chính
        public virtual DateTime? BirthDate { get; set; } // ngày sinh
        public virtual int BirthYear { get; set; } // năm sinh
        public virtual string BirthPlace { get; set; } // nơi sinh
        public virtual Guid GenderId { get; set; } // giới tính
        public virtual Guid EthnicityId { get; set; } // dân tộc
        public virtual Guid CountryId { get; set; } // quốc tịch
        public virtual Guid? ProvinceOrCityId { get; set; } // tỉnh, thành phố
        public virtual Guid? DistrictId { get; set; } // quận, huyện
        public virtual Guid? WardId { get; set; } // xã, phường
        public virtual string Address { get; set; } // địa chỉ số nhà, thôn, phố
        public virtual Guid CareerId { get; set; } // nghề nghiệp
        public virtual string Workplace { get; set; } // nơi làm việc
        public virtual string IdentificationNumber { get; set; } // số cmnd, cccd, số hộ chiếu
        public virtual DateTime? IssueDate { get; set; } // ngày cấp
        public virtual string IssueBy { get; set; } // nơi cấp

        // thông tin đăng ký dịch vụ khám
        public virtual bool PatientTypeId { get; set; } // đối tượng bệnh nhân
        public virtual bool IsPriority { get; set; } // là trường hợp ưu tiên
        public virtual int ReceptionTypeId { get; set; } // đối tượng tiếp nhận (khám bệnh hay cấp cứu)
        public virtual DateTime ReceptionDate { get; set; } // ngày đăng ký khám
        public virtual string HospitalizationReason { get; set; } // lý do khám
        public virtual Guid? ServiceId { get; set; } // dịch vụ chỉ định khám
        public virtual Guid? ExecuteDepartmentId { get; set; } // khoa chỉ định thực hiện dịch vụ khám
        public virtual Guid? ExecuteRoomId { get; set; } // phòng thực chỉ định hiện dịch vụ khám
        public virtual string Description { get; set; } // ghi chú

        // thông tin bhyt
        public virtual string InsuranceCode { get; set; }
        public virtual DateTime? InsuranceFromDate { get; set; }
        public virtual DateTime? InsuranceToDate { get; set; }
        public virtual string LiveAreaCode { get; set; } // nơi sống (K1, K2, K3)
        public virtual string InsuranceMediOrgCode { get; set; } // nơi đăng ký khám chữa bệnh ban đầu
        public virtual string InsuranceMediOrgName { get; set; } // nơi đăng ký khám chữa bệnh ban đầu
        public virtual string InsuranceAddress { get; set; } // địa chỉ thẻ
        public virtual string LevelCode { get; set; } // tuyến kcb
        public virtual bool HasBirthCertificate { get; set; } // TE có giấy khai sinh
        public virtual DateTime? FreeCoPaidDate { get; set; } // ngày miễn cùng chi trả
        public virtual DateTime? Join5YearDate { get; set; } // ngày đóng đủ 5 năm liên tục

        public ReceptionDto() 
        {
            
        }
    }
}
