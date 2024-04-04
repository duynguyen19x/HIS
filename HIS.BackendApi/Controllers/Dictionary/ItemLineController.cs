using HIS.ApplicationService.Dictionaries.ItemLines;
using HIS.Dtos.Dictionaries.ItemLines;
using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;

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
        public async Task<PagedResultDto<ItemLineDto>> GetAll([FromQuery] GetAllItemLineInput input)
        {
            return await _ItemLineService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<ItemLineDto>> GetById(Guid id)
        {
            return await _ItemLineService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<ItemLineDto>> CreateOrEdit(ItemLineDto input)
        {
            return await _ItemLineService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<ItemLineDto>> Delete(Guid id)
        {
            return await _ItemLineService.Delete(id);
        }
    }
}
