using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Thông tin bảo hiểm
    /// </summary>
    [Table("DInsurance")]
    public class Insurance : AuditedEntity<Guid>
    {
        public Guid MedicalRecordID { get; set; }

        public Guid PatientID { get; set; }

        [StringLength(PatientConst.PatientNameLength)]
        public string PatientName { get; set; }

        public DateTime? BirthDate { get; set; }

        public Guid? GenderID { get; set; }

        [Required]
        [StringLength(InsuranceConst.MaxInsuranceCodeLength, MinimumLength = InsuranceConst.MinInsuranceCodeLength)]
        public string InsuranceCode { get; set; } // mã thẻ

        [StringLength(InsuranceConst.MaxMediOrgCodeLength, MinimumLength = InsuranceConst.MinMediOrgCodeLength)]
        public string MediOrgCode { get; set; } // mã nơi KCBBĐ

        [StringLength(InsuranceConst.MaxMediOrgNameLength, MinimumLength = InsuranceConst.MinMediOrgNameLength)]
        public string MediOrgName { get; set; } // tên nơi KCBBĐ

        [StringLength(InsuranceConst.MaxAddressLength, MinimumLength = InsuranceConst.MinAddressLength)]
        public string Address { get; set; } // địa chỉ thẻ
         
        public DateTime? FromDate { get; set; } // hạn thẻ từ ngày

        public DateTime? ToDate { get; set; } // hạn thẻ đến ngày

        public int LiveAreaID { get; set; } // nơi sống

        public int RightRouteTypeID { get; set; } // tuyến KCB

        public DateTime? Join5YearTime { get; set; } // ngày đủ 5 năm liên tục

        public DateTime? FreeCoPaidTime { get; set; } // ngày miễn cùng chi trả

        public bool HasBirthCertificate { get; set; } // trẻ em có giấy khai sinh

        [StringLength(InsuranceConst.MaxDescriptionLength, MinimumLength = InsuranceConst.MinDescriptionLength)]
        public string Description { get; set; }
    }
}
