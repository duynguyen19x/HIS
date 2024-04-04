using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;
using HIS.ApplicationService.Dictionary.RoomTypes;
using HIS.ApplicationService.Dictionary.RoomTypes.Dto;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypeController : ControllerBase
    {
        private readonly IRoomTypeAppService _roomTypeService;

        public RoomTypeController(IRoomTypeAppService roomTypeService)
        {
            _roomTypeService = roomTypeService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<RoomTypeDto>> GetAll([FromQuery] GetAllRoomTypeInputDto input)
        {
            return await _roomTypeService.GetAllAsync(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<RoomTypeDto>> GetById(int id)
        {
            return await _roomTypeService.GetAsync(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<RoomTypeDto>> CreateOrEdit(RoomTypeDto input)
        {
            return await _roomTypeService.CreateOrUpdateAsync(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<RoomTypeDto>> Delete(int id)
        {
            return await _roomTypeService.DeleteAsync(id);
        }
    }
}
