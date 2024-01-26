using HIS.Core.Application.Services.Dto;

namespace HIS.Dtos.Business.PatientRecords
{
    public class GetAllPatientRecordInputDto : PagedAndSortedResultRequestDto
    {
        public string PatientCodeFilter { get; set; }
        public string PatientNameFilter { get; set; }
        public string PatientRecordCodeFilter { get; set; }
        public DateTime? MaxPatientRecordDateFilter { get; set; }
        public DateTime? MinPatientRecordDateFilter { get; set; }
        public DateTime? MaxBirthDateFilter { get; set; }
        public DateTime? MinBirthDateFilter { get; set; }
        public int? MaxBirthYearFilter { get; set; }
        public int? MinBirthYearFilter { get; set; }
        public Guid? GenderFilter { get; set; }
        public Guid? EthnicFilter { get; set; }
        public Guid? ReligionFilter { get; set; }
        public Guid? NationalFilter { get; set; }
        public Guid? ProvinceFilter { get; set; }
        public Guid? DistrictFilter { get; set; }
        public Guid? WardFilter { get; set; }
        public Guid? CareerFilter { get; set; }

        public GetAllPatientRecordInputDto() { }
    }
}
