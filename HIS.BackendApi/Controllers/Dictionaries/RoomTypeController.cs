using HIS.ApplicationService.Dictionaries.RoomType;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.RoomType;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ApiResultList<RoomTypeDto>> GetAll([FromQuery] GetAllRoomTypeInput input)
        {
            return await _roomTypeService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<RoomTypeDto>> GetById(int id)
        {
            return await _roomTypeService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<RoomTypeDto>> CreateOrEdit(RoomTypeDto input)
        {
            return await _roomTypeService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<RoomTypeDto>> Delete(int id)
        {
            return await _roomTypeService.Delete(id);
        }
    }
}
