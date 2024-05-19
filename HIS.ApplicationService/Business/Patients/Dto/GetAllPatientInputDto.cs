using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Patients.Dto
{
    public class GetAllPatientInputDto : PagedAndSortedResultRequestDto
    {
        public string PatientCodeFilter { get; set; }
        public string PatientNameFilter { get; set; }
        public DateTime? MaxBirthDate { get; set; }
        public DateTime? MinBirthDate { get; set; }
        public string BirthPlaceFilter { get; set; }
        public Guid? BloodRhTypeFilter { get; set; }
        public Guid? BloodTypeFilter { get; set; }
        public Guid? GenderFilter { get; set; }
        public Guid? CareerFilter { get; set; }
        public Guid? EthnicityFilter { get; set; }
        public Guid? ReligionFilter { get; set; }
        public Guid? CountryFilter { get; set; }
        public Guid? ProvinceFilter { get; set; }
        public Guid? DistrictFilter { get; set; }
        public Guid? WardFilter { get; set; }
        public string AddressFilter { get; set; }
        public string PhoneNumberFilter { get; set; }
        public string EmailFilter { get; set; }
        public string WorkPlaceFilter { get; set; }
        public string IdentificationNumberFilter { get; set; }
        public DateTime? MaxIssueDateFilter { get; set; }
        public DateTime? MinIssueDateFilter { get; set; }
        public string IssueByFilter { get; set; }
        public string ContactNameFilter { get; set; }
        public string ContactPhoneNumberFilter { get; set; }
        public string ContactAddressFilter { get; set; }

        public Guid? BranchFilter { get; set; }
    }
}
