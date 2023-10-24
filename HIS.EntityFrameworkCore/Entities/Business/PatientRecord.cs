using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Thông tin điều trị.
    /// </summary>
    public class PatientRecord : FullAuditedEntity<Guid>
    {
        public string Code { get; set; } // mã điều trị
        public string Name { get; set; } // tên bệnh nhân
        public DateTime? BirthDate { get; set; }
        public int BirthYear { get; set; }
        public string BirthPlace { get; set; }
        public Guid GenderId { get; set; }
        public Guid EthnicId { get; set; }
        public Guid? BloodTypeId { get; set; }
        public Guid? BloodTypeRhId { get; set; }
        public Guid? CountryId { get; set; }
        public Guid? ProvinceOrCityId { get; set; }
        public Guid? DistrictId { get; set; }
        public Guid? WardOrCommuneId { get; set; }
        public string Address { get; set; }
        public Guid CareerId { get; set; }
        public string WorkPlace { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Phone { get; set; }
        public string IdentificationNumber { get; set; }
        public DateTime? IssueDate { get; set; }
        public string IssueBy { get; set; }

        public Guid? RalativeTypeId { get; set; }
        public string RelativeName { get; set; }
        public string RelativeAddress { get; set; }
        public string RelativeTel { get; set; }
        public string RelativePhone { get; set; }
        public string RelativeIdentificationNumber { get; set; }
        public DateTime? RelativeIssueDate { get; set; }
        public string RelativeIssueBy { get; set; }

        public int PatientTypeId { get; set; }
        public int PatientRecordType { get; set; }
        public int PatientRecordStatus { get; set; }
        public DateTime PatientRecordDate { get; set; }
        public string StoreCode { get; set; } // số lưu trữ
        public string InCode { get; set; } // số vào viện
        public Guid? PatientId { get; set; } // thông tin điều trị chính (tách bệnh án)

        public DateTime ReceptionDate { get; set; }
        public string LyDoDenKham { get; set; }


        public string Description { get; set; }

    }
}
