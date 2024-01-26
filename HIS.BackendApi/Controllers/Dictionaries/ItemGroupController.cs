using HIS.ApplicationService.Dictionaries.ItemGroups;
using HIS.Dtos.Dictionaries.ItemGroups;
using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemGroupController : ControllerBase
    {
        private readonly IItemGroupService _sItemGroupService;

        public ItemGroupController(IItemGroupService sItemGroupService)
        {
            _sItemGroupService = sItemGroupService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<ItemGroupDto>> GetAll([FromQuery] GetAllItemGroupInput input)
        {
            return await _sItemGroupService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<ItemGroupDto>> GetById(Guid id)
        {
            return await _sItemGroupService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<ItemGroupDto>> CreateOrEdit(ItemGroupDto input)
        {
            return await _sItemGroupService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<ItemGroupDto>> Delete(Guid id)
        {
            return await _sItemGroupService.Delete(id);
        }
    }
}
