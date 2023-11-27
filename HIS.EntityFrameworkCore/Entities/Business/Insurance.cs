using HIS.Core.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Thông tin bảo hiểm y tế.
    /// </summary>
    public class Insurance : FullAuditedEntity<Guid>
    {
        public Guid PatientID { get; set; }
        public Guid MedicalRecordID { get; set; }
        public string InsuranceCode { get; set; }
        public string PatientName { get; set; } // tên bệnh nhân (lấy từ thẻ bhyt)
        public string BirthDate { get; set; } // ngày sinh
        public Guid? GenderID { get; set; } // giới tính 
        public string MediOrgCode { get; set; } // mã kcbbd 
        public DateTime? FromDate { get; set; } // hạn thẻ từ
        public DateTime? ToDate { get; set; } // hạn thẻ đến
        public Guid? LiveAreaCode { get; set; } // nơi sống
        public string Address { get; set; } // địa chi thẻ
        public int InsuranceRouteTypeID { get; set; } // tuyến KCB (đúng tuyến, trái tuyến,....)
        public DateTime? Join5YearDate { get; set; } // ngày đóng đủ 5 năm liên tục
        public DateTime? FreeCopaymentDate { get; set;} // ngày miễn cùng chi trả 
        public int SortOrder { get; set; }
    }
}
