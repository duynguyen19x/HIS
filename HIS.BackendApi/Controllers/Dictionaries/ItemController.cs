using HIS.Core.Services.Dto;
using HIS.ApplicationService.Dictionaries.ItemGroups;
using HIS.Dtos.Dictionaries.ItemGroups;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemGroupService _sItemGroupService;

        public ItemController(IItemGroupService sItemGroupService)
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
