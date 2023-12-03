using HIS.Application.Core.Services.Dto;
using HIS.ApplicationService.Dictionaries.Room;
using HIS.Dtos.Dictionaries.Room;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomAppService _roomService;

        public RoomController(IRoomAppService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<RoomDto>> GetAll([FromQuery] GetAllRoomInput input)
        {
            return await _roomService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<RoomDto>> GetById(Guid id)
        {
            return await _roomService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<RoomDto>> CreateOrEdit(RoomDto input)
        {
            return await _roomService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<RoomDto>> Delete(Guid id)
        {
            return await _roomService.Delete(id);
        }

        [HttpGet("GetByStocks")]
        public async Task<PagedResultDto<RoomDto>> GetByStocks()
        {
            return await _roomService.GetByStocks();
        }
    }
}
