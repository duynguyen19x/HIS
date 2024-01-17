using HIS.Core.Services.Dto;
using HIS.ApplicationService.Dictionaries.ItemTypes;
using HIS.Dtos.Dictionaries.ItemTypes;
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
        public async Task<PagedResultDto<ItemTypeDto>> GetAll([FromQuery] GetAllItemTypeInput input)
        {
            return await _sItemTypeService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<ItemTypeDto>> GetById(Guid id)
        {
            return await _sItemTypeService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<ItemTypeDto>> CreateOrEdit(ItemTypeDto input)
        {
            return await _sItemTypeService.CreateOrEdit(input);
        }

        [HttpPost("Import")]
        public async Task<ResultDto<bool>> Import(IList<ItemTypeDto> input)
        {
            return await _sItemTypeService.Import(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<ItemTypeDto>> Delete(Guid id)
        {
            return await _sItemTypeService.Delete(id);
        }
    }
}
