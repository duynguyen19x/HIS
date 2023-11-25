using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.Receptions
{
    public class GetAllReceptionInput : PagedResultRequestDto
    {
        public DateTime? MaxReceptionDateFilter { get; set; }
        public DateTime? MinReceptionDateFilter { get; set; }
        public int? PatientTypeFilter { get; set; }
        public int? PatientRecordTypeFilter { get; set; }
        public int? ReceptionTypeFilter { get; set; }
    }
}
