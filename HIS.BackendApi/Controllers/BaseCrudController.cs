using HIS.Application.Core.Services;
using HIS.Core.Services.Dto;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseCrudController<TAppService, TEntityDto, TPrimaryKey, TPagedRequestDto> : ControllerBase
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TPagedRequestDto : IPagedResultRequest
        where TAppService : IBaseCrudAppService<TEntityDto, TPrimaryKey, TPagedRequestDto>
    {
        private readonly TAppService _appService;

        public BaseCrudController(TAppService appService) 
        {
            _appService = appService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<TEntityDto>> GetAll([FromQuery] TPagedRequestDto input)
        {
            return await _appService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<TEntityDto>> GetById(TPrimaryKey id)
        {
            return await _appService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<TEntityDto>> CreateOrEdit(TEntityDto input)
        {
            return await _appService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<TEntityDto>> Delete(TPrimaryKey id)
        {
            return await _appService.Delete(id);
        }
    }
}
