using HIS.Application.Core.Services.Dto;
using HIS.ApplicationService.Business.Receptions;
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
        public async Task<ResultDto<ReceptionDto>> CreateOrEdit(ReceptionDto input)
        {
            return await _receptionAppService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<ReceptionDto>> Delete(Guid id)
        {
            return await _receptionAppService.Delete(id);
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<ReceptionDto>> GetAll(ReceptionRequestDto input)
        {
            return await _receptionAppService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<ReceptionDto>> GetById(Guid id)
        {
            return await _receptionAppService.GetById(id);
        }
    }
}
