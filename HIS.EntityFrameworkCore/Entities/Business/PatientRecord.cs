using AutoMapper.Configuration.Annotations;
using HIS.Core.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// hồ sơ bệnh án.
    /// </summary>
    public class PatientRecord : FullAuditedEntity<Guid>
    {
        public virtual string Code { get; set; } // mã điều trị
              
        public virtual Guid PatientId { get; set; } // mã bệnh nhân
        public virtual string PatientName { get; set; } // tên bệnh nhân
        public virtual DateTime? BirthDate { get; set; }
        public virtual int BirthYear { get; set; }
        public virtual string BirthPlace { get; set; }
        public virtual Guid GenderId { get; set; }
        public virtual Guid EthnicId { get; set; }
        public virtual Guid? CountryId { get; set; }
        public virtual Guid? ProvinceId { get; set; }
        public virtual Guid? DistrictId { get; set; }
        public virtual Guid? WardId { get; set; }
        public virtual string Address { get; set; }
        public virtual Guid CareerId { get; set; }
        public virtual string WorkPlace { get; set; }
        public virtual string Email { get; set; }
        public virtual string Tel { get; set; }
        public virtual string Mobile { get; set; }
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

        // giấy giới thiệu (thông tin chuyển tuyến đến)


        // khám bệnh
        public virtual DateTime? ClinicalTime { get; set; } // thời gian bắt đầu khám
        public virtual Guid? ClinicalDepartmentId { get; set; } // khoa khám bệnh
        public virtual Guid? ClinicalRoomId { get; set; } // phòng khám bệnh

        // vào viện
        public virtual DateTime InTime { get; set; }  // thời gian nhập viện
        public virtual Guid? InDepartmentId { get; set; }
        public virtual Guid? InRoomId { get; set; }

        // ra viện
        public virtual DateTime? OutTime { get; set; } // thời gian ra viện
        public virtual Guid? OutDepartmentId { get; set; }
        public virtual Guid? OutRoomId { get; set; }

        public string IcdCode { get; set; } // mã bệnh chính
        public string IcdName { get; set; } // tên bệnh chính
        public string IcdSubCode { get; set; } // mã bệnh kèm theo
        public string IcdText { get; set; } // danh sách mã bệnh kèm theo




        [Ignore]
        public Patient Patient { get; set; }

        [Ignore]
        public Gender Gender { get; set; }

        [Ignore]
        public Ethnicity Ethnic { get; set; }

        [Ignore]
        public BloodType BloodType { get; set; }

        [Ignore]
        public BloodTypeRh BloodTypeRh { get; set; }

        [Ignore]
        public Country Country { get; set; }

        [Ignore]
        public Province Province { get; set; }

        [Ignore]
        public District District { get; set; }

        [Ignore]
        public SWard Ward { get; set; }

        [Ignore]
        public Career Career { get; set; }
    }
}
