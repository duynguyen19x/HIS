using HIS.ApplicationService.Dictionaries.RoomType;
using HIS.Dtos.Dictionaries.RoomType;
using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypeController : ControllerBase
    {
        private readonly IRoomTypeService _roomTypeService;

        public RoomTypeController(IRoomTypeService roomTypeService)
        {
            _roomTypeService = roomTypeService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<RoomTypeDto>> GetAll([FromQuery] GetAllRoomTypeInput input)
        {
            return await _roomTypeService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<RoomTypeDto>> GetById(int id)
        {
            return await _roomTypeService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<RoomTypeDto>> CreateOrEdit(RoomTypeDto input)
        {
            return await _roomTypeService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<RoomTypeDto>> Delete(int id)
        {
            return await _roomTypeService.Delete(id);
        }
    }
}
