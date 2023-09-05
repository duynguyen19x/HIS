using HIS.ApplicationService.Dictionaries.ItemLines;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ItemLines;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemLineController : ControllerBase
    {
        private readonly IItemLineService _ItemLineService;

        public ItemLineController(IItemLineService ItemLineService)
        {
            _ItemLineService = ItemLineService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<ItemLineDto>> GetAll([FromQuery] GetAllItemLineInput input)
        {
            return await _ItemLineService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<ItemLineDto>> GetById(Guid id)
        {
            return await _ItemLineService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<ItemLineDto>> CreateOrEdit(ItemLineDto input)
        {
            return await _ItemLineService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<ItemLineDto>> Delete(Guid id)
        {
            return await _ItemLineService.Delete(id);
        }
    }
}
