using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.Patients
{
    public class GetAllPatientInput : PagedResultRequestDto
    {
        public string PatientCodeFilter { get; set; }
        public string PatientNameFilter { get; set; }
        public DateTime? MaxBirthDateFilter { get; set; }
        public DateTime? MinBirthDateFilter { get; set; }
        public int? MaxBirthYearFilter { get; set; }
        public int? MinBirthYearFilter { get; set; }
        public string BirthPlaceFilter { get; set; }
        public Guid? GenderFilter { get; set; }
        public Guid? EthnicityFilter { get; set; }
        public Guid? CountryFilter { get; set; }
        public Guid? ProvinceOrCityFilter { get; set; }
        public Guid? DistrictFilter { get; set; }
        public Guid? WardOrCommuneFilter { get; set; }
        public string AddressFilter { get; set; }
        public string TelFilter { get; set; }
        public string MobileFilter { get; set; }
        public string IdentificationNumberFilter { get; set; }
    }
}
