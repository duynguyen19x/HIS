using HIS.ApplicationService.Business.Patients;
using HIS.ApplicationService.Business.Patients.Dto;
using HIS.ApplicationService.Dictionary.Rooms.Dto;
using HIS.Core.Application.Services.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Business
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientAppService _patientAppService;

        public PatientController(IPatientAppService patientAppService) 
        {
            _patientAppService = patientAppService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<PatientDto>> GetAll([FromQuery] GetAllPatientInputDto input)
        {
            return await _patientAppService.GetAll(input);
        }

        [HttpGet("Get")]
        public async Task<ResultDto<PatientDto>> Get(Guid id)
        {
            return await _patientAppService.Get(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<PatientDto>> CreateOrEdit(PatientDto input)
        {
            return await _patientAppService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<PatientDto>> Delete(Guid id)
        {
            return await _patientAppService.Delete(id);
        }
    }
}
