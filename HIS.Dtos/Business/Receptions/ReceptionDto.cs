using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.Receptions
{
    /// <summary>
    /// Dữ liệu cho chức năng tiếp đón
    /// </summary>
    public class ReceptionDto : EntityDto<Guid>
    {
        public Guid PatientID { get; set; }
        public Guid PatientRecordID { get; set; }
        public string PatientRecordCode { get; set; } // mã điều trị
        public string PatientCode { get; set; } // mã bệnh nhân
        public string PatientName { get; set; } // tên bệnh nhân
        public DateTime? BirthDate { get; set; } // ngày sinh
        public int BirthYear { get; set; } // năm sinh
        
        public string Description { get; set; } // ghi chú
    }
}
