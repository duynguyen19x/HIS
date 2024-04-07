using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Receptions.Dto
{
    public class GetAllReceptionInputDto : PagedAndSortedResultRequestDto
    {
        public DateTime? ReceptionFromDateFilter { get; set; }

        public DateTime? ReceptionToDateFilter { get; set; }

        public int? ReceptionObjectTypeFilter { get; set; }

        public int? PatientObjectTypeFilter { get; set; }

        public Guid? BranchFilter { get; set; }

        public Guid? DepartmentFilter { get; set; }

        public Guid? RoomFilter { get; set; }

        public Guid? UserFilter { get; set; }

        public Guid? ExecuteDepartmentFilter { get; set; }

        public Guid? ExecuteRoomFilter { get; set; }

        public Guid? ExecuteUserFilter { get; set; }

    }
}
