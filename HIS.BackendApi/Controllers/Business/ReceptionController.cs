using Azure;
using HIS.ApplicationService.Business.Reception;
using HIS.ApplicationService.Business.Reception.Dto;
using HIS.ApplicationService.Dictionary.Suppliers.Dto;
using HIS.Core.Application.Services.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

    }
}
