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
        public DateTime? MaxReceptionDateFilter { get; set; }
        public DateTime? MinReceptionDateFilter { get; set; }

        public Guid? UserFilter { get; set; }
        public Guid? BranchFilter { get; set; }
        public Guid? DepartmentFilter { get; set; }
        public Guid? RoomFilter { get; set; }
        public string GateFilter { get; set; }
        

    }
}
