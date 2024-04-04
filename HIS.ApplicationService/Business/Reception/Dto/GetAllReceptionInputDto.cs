using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Reception.Dto
{
    public class GetAllReceptionInputDto : PagedAndSortedResultRequestDto
    {
        public Guid? PatientFilter { get; set; }
        public Guid? PatientRecordFilter { get; set; }
        public Guid? RoomFilter { get; set; }
        public Guid? DepartmentFilter { get; set; }
        public Guid? BranchFilter { get; set; }
        public Guid? ServiceFilter { get; set; }
        public long? ReceptionFromDateFilter { get; set; }
        public long? ReceptionToDateFilter { get; set; }

    }
}
