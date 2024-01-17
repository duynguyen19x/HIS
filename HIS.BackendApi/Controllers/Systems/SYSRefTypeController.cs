using HIS.ApplicationService.Systems.RefType;
using HIS.Core.Services.Dto;
using HIS.Core.Services;
using HIS.Dtos.Systems;
using HIS.Dtos.Systems.RefType;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Systems
{
    [Route("api/[controller]")]
    [ApiController]
    public class SYSRefTypeController : ControllerBase //BaseCrudController<ISYSRefTypeAppService, SYSRefTypeDto, int, GetAllSYSRefTypeInputDto>
    {
        private readonly ISYSRefTypeAppService sYSRefTypeAppService;

        public SYSRefTypeController(ISYSRefTypeAppService appService) 
        {
            sYSRefTypeAppService = appService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<SYSRefTypeDto>> GetAll([FromQuery] GetAllSYSRefTypeInputDto input)
        {
            return await sYSRefTypeAppService.GetAll(input);
        }
    }
}
