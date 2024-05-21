using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.MedicalRecords.Dto
{
    public class GetAllMedicalRecordInputDto : PagedAndSortedResultRequestDto
    {
        public Guid PatientFilter { get; set; }
        public DateTime? MaxMedicalRecordDateFilter { get; set; }
        public DateTime? MinMedicalRecordDateFilter { get; set; }
        public string MedicalRecordCodeFilter { get; set; }
        public int? MedicalRecordTypeFilter { get; set; }
        public int? MedicalRecordStatusFilter { get; set; }
        public Guid? BranchFilter { get; set; }
        public Guid? DepartmentFilter { get; set; }
        public Guid? RoomFilter { get; set; }

    }
}
