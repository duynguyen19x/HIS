using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.Patients
{
    public class GetAllPatientInputDto : PagedResultRequestDto
    {
        public string PatientCodeFilter { get; set; }
        public string PatientNameFilter { get; set; }
        public int? MaxBirthYear { get; set; }
        public int? MinBirthYear { get; set; }
        public DateTime? MaxBirthDate { get; set; }
        public DateTime? MinBirthDate { get; set; }
        public string BirthplaceFilter { get; set; }
        public Guid? GenderFilter { get; set; }
        public Guid? EthnicFilter { get; set; }
        public Guid? ReligionFilter { get; set; }
        public Guid? CountryFilter { get; set; }
        public Guid? ProvinceFilter { get; set; }
        public Guid? DistrictFilter { get; set; }
        public Guid? WardFilter { get; set; }
        public Guid? CareerFilter { get; set; }
        public string WorkplaceFilter { get; set; }
        public string IdentificationNumberFilter { get; set; }
        public DateTime? MaxIssueDateFilter { get; set; }
        public DateTime? MinIssueDateFilter { get; set; }
        public string IssueByFilter { get; set; }
        public string TelFilter { get; set; }
        public string MobileFilter { get; set; }
        public string EmailFilter { get; set; }

    }
}
