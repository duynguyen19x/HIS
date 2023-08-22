using HIS.Application.Core.Services.Dto;
using HIS.ApplicationService.Business.Patient;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Business.Patient;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Business.Patient
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

        [HttpGet("GetById")]
        public async Task<ResultDto<PatientDto>> GetById(Guid id)
        {
            return await _patientAppService.GetById(id);
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
