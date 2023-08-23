using HIS.Application.Core.Services.Dto;
using HIS.ApplicationService.Business;
using HIS.Dtos.Business;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Business.Patient
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientRecordController : ControllerBase
    {
        private readonly IPatientRecordAppService PatientRecordAppService;

        public PatientRecordController(IPatientRecordAppService patientRecordAppService)
        {
            PatientRecordAppService = patientRecordAppService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<PatientRecordDto>> GetAll([FromQuery] GetAllPatientRecordInputDto input)
        {
            return await PatientRecordAppService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<PatientRecordDto>> GetById(Guid id)
        {
            return await PatientRecordAppService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<PatientRecordDto>> CreateOrEdit(PatientRecordDto input)
        {
            return await PatientRecordAppService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<PatientRecordDto>> Delete(Guid id)
        {
            return await PatientRecordAppService.Delete(id);
        }
    }
}
