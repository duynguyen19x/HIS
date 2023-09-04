using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.Receptions
{
    public class ReceptionRequestDto : PagedResultRequestDto
    {
        public string PatientCodeFilter { get; set; }
        public string PatientNameFilter { get; set; }
        public Guid? GenderIdFilter { get; set; }
        public int? AgeFromFilter { get; set; }
        public int? AgeToFilter { get; set; }
        public DateTime? BirthDateFromFilter { get; set; }
        public DateTime? BirthDateToFilter { get; set; }
        public DateTime? ReceptionDateFromFilter { get; set; }
        public DateTime? ReceptionDateToFilter { get; set; }
        public Guid? RequestRoomIdFilter { get; set; }
        public Guid? RequestUserIdFilter { get; set; }
        public Guid? ExecuteRoomIdFilter { get; set; }
        public Guid? ExecuteUserIdFilter { get; set; }

        public int? PatientTypeIdFilter { get; set; }
        public int? PatientRecordStatusIdFilter { get; set; }
        public int? MedicalRecordStatusIdFilter { get; set; }
    }
}
