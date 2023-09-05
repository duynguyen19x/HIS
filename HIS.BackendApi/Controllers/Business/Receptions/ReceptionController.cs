using HIS.Application.Core.Services.Dto;
using HIS.ApplicationService.Business.Receptions;
using HIS.Dtos.Business.PatientRecords;
using HIS.Dtos.Business.Receptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Business.Receptions
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceptionController : ControllerBase
    {
        private readonly IReceptionAppService _receptionAppService;

        public ReceptionController(IReceptionAppService receptionAppService)
        {
            _receptionAppService = receptionAppService;
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<PatientRecordDto>> CreateOrEdit(PatientRecordDto input)
        {
            return await _receptionAppService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<PatientRecordDto>> Delete(Guid id)
        {
            return await _receptionAppService.Delete(id);
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<PatientRecordDto>> GetAll([FromQuery] PatientRecordRequestDto input)
        {
            return await _receptionAppService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<PatientRecordDto>> GetById(Guid id)
        {
            return await _receptionAppService.GetById(id);
        }
    }
}
