using HIS.ApplicationService.Business.Patient;
using HIS.Dtos.Business.Patient;
using HIS.Dtos.Business.Treatment;
using HIS.Dtos.Commons;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Business.Patient
{
    [Route("api/[controller]")]
    [ApiController]
    public class SPatientController : ControllerBase
    {
        private readonly ISPatientService _patientService;

        public SPatientController(ISPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SPatientDto>> GetAll([FromQuery] GetAllSPatientInput input)
        {
            return await _patientService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<SPatientDto>> GetById(Guid id)
        {
            return await _patientService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<SPatientDto>> CreateOrEdit(SPatientDto input)
        {
            return await _patientService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<SPatientDto>> Delete(Guid id)
        {
            return await _patientService.Delete(id);
        }

        [HttpPost("RegisterOrEdit")]
        public async Task<ApiResult<STreatmentDto>> RegisterOrEdit(STreatmentDto input)
        {
            return await _patientService.RegisterOrEdit(input);
        }
    }
}
