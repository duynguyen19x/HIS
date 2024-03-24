using HIS.ApplicationService.Systems.DbOptions;
using HIS.Dtos.Systems.DbOption;
using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;

namespace HIS.BackendApi.Controllers.Systems.DbOption
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbOptionController : ControllerBase
    {
        private readonly IDbOptionAppService _iDbOptionAppService;

        public DbOptionController(IDbOptionAppService iDbOptionAppService)
        {
            _iDbOptionAppService = iDbOptionAppService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<DbOptionDto>> GetAll([FromQuery] GetAllDbOptionInput input)
        {
            return await _iDbOptionAppService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<DbOptionDto>> GetById(Guid id)
        {
            return await _iDbOptionAppService.GetById(id);
        }

        [HttpGet("GetMapOptions")]
        public async Task<ResultDto<OptionValueDto>> GetMapOptions()
        {
            return await _iDbOptionAppService.GetMapOptions();
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<DbOptionDto>> CreateOrEdit(DbOptionDto input)
        {
            return await _iDbOptionAppService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<DbOptionDto>> Delete(Guid id)
        {
            return await _iDbOptionAppService.Delete(id);
        }
    }
}
