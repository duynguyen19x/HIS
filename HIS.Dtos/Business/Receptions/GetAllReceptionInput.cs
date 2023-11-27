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
        public int? ReceptionTypeFilter { get; set; }
        public Guid? GenderFilter { get; set; }
        public Guid? DepartmentFilter { get; set; }
        public Guid? RoomFilter { get; set; }
        public Guid? UserFilter { get; set; }
        public Guid? ExecuteDepartmentFilter { get; set; }
        public Guid? ExecuteRoomFilter { get; set; }
        public Guid? ExecuteUserFilter { get; set; }
    }
}
