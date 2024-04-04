using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;
using HIS.ApplicationService.Dictionary.Rooms.Dto;

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
        public async Task<PagedResultDto<RoomDto>> GetAll([FromQuery] GetAllRoomInputDto input)
        {
            return await _roomService.GetAllAsync(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<RoomDto>> GetById(Guid id)
        {
            return await _roomService.GetAsync(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<RoomDto>> CreateOrEdit(RoomDto input)
        {
            return await _roomService.CreateOrUpdateAsync(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<RoomDto>> Delete(Guid id)
        {
            return await _roomService.DeleteAsync(id);
        }

        [HttpGet("GetByStocks")]
        public async Task<PagedResultDto<RoomDto>> GetByStocks()
        {
            return await _roomService.GetByStocks();
        }
    }
}
