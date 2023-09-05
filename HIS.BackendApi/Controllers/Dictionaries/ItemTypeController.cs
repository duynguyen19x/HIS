using HIS.ApplicationService.Dictionaries.ItemTypes;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ItemTypes;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemTypeController : ControllerBase
    {
        private readonly IItemTypeService _sItemTypeService;

        public ItemTypeController(IItemTypeService sItemTypeService)
        {
            _sItemTypeService = sItemTypeService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<ItemTypeDto>> GetAll([FromQuery] GetAllItemTypeInput input)
        {
            return await _sItemTypeService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<ItemTypeDto>> GetById(Guid id)
        {
            return await _sItemTypeService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<ItemTypeDto>> CreateOrEdit(ItemTypeDto input)
        {
            return await _sItemTypeService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<ItemTypeDto>> Delete(Guid id)
        {
            return await _sItemTypeService.Delete(id);
        }
    }
}
