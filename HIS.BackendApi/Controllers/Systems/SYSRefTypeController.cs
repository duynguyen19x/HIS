using HIS.ApplicationService.Systems.RefType;
using HIS.Core.Services.Dto;
using HIS.Core.Services;
using HIS.Dtos.Systems;
using HIS.Dtos.Systems.RefType;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HIS.Dtos.Dictionaries.Branchs;

namespace HIS.BackendApi.Controllers.Systems
{
    [Route("api/[controller]")]
    [ApiController]
    public class SYSRefTypeController : ControllerBase //BaseCrudController<ISYSRefTypeAppService, SYSRefTypeDto, int, GetAllSYSRefTypeInputDto>
    {
        private readonly ISYSRefTypeAppService _sysRefTypeAppService;

        public SYSRefTypeController(ISYSRefTypeAppService appService) 
        {
            _sysRefTypeAppService = appService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<SYSRefTypeDto>> GetAll([FromQuery] GetAllSYSRefTypeInputDto input) => await _sysRefTypeAppService.GetAllAsync(input);

        [HttpGet("GetById")]
        public async Task<ResultDto<SYSRefTypeDto>> GetById(int id) => await _sysRefTypeAppService.GetAsync(id);

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<SYSRefTypeDto>> CreateOrEdit(SYSRefTypeDto input) => await _sysRefTypeAppService.CreateOrUpdateAsync(input);

        [HttpDelete("Delete")]
        public async Task<ResultDto<SYSRefTypeDto>> Delete(int id) => await _sysRefTypeAppService.DeleteAsync(id);
    }
}
