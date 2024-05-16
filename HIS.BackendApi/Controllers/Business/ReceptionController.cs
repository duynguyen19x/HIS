using HIS.ApplicationService.Business.Patients.Dto;
using HIS.ApplicationService.Business.Patients;
using HIS.Core.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using HIS.ApplicationService.Business.Receptions;
using HIS.ApplicationService.Business.Receptions.Dto;

namespace HIS.BackendApi.Controllers.Business
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

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<ReceptionDto>> GetAll([FromQuery] GetAllReceptionInputDto input)
        {
            return await _receptionAppService.GetAll(input);
        }

        [HttpGet("Get")]
        public async Task<ResultDto<ReceptionDto>> Get(Guid id)
        {
            return await _receptionAppService.Get(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<ReceptionDto>> CreateOrEdit(ReceptionDto input)
        {
            return await _receptionAppService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<ReceptionDto>> Delete(Guid id)
        {
            return await _receptionAppService.Delete(id);
        }

    }
}
