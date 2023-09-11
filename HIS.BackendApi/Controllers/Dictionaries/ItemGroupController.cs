using HIS.ApplicationService.Dictionaries.ItemGroups;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ItemGroups;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ApiResultList<ItemGroupDto>> GetAll([FromQuery] GetAllItemGroupInput input)
        {
            return await _sItemGroupService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<ItemGroupDto>> GetById(Guid id)
        {
            return await _sItemGroupService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<ItemGroupDto>> CreateOrEdit(ItemGroupDto input)
        {
            return await _sItemGroupService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<ItemGroupDto>> Delete(Guid id)
        {
            return await _sItemGroupService.Delete(id);
        }
    }
}
