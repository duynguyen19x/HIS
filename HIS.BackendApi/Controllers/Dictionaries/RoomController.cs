using HIS.ApplicationService.Dictionaries.Room;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Room;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<RoomDto>> GetAll([FromQuery] GetAllRoomInput input)
        {
            return await _roomService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<RoomDto>> GetById(Guid id)
        {
            return await _roomService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<RoomDto>> CreateOrEdit(RoomDto input)
        {
            return await _roomService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<RoomDto>> Delete(Guid id)
        {
            return await _roomService.Delete(id);
        }

        [HttpGet("GetByStocks")]
        public async Task<ApiResultList<RoomDto>> GetByStocks()
        {
            return await _roomService.GetByStocks();
        }
    }
}
