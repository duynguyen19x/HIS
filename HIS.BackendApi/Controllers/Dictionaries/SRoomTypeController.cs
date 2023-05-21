using HIS.ApplicationService.Dictionaries.Room;
using HIS.ApplicationService.Dictionaries.RoomType;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Room;
using HIS.Dtos.Dictionaries.RoomType;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SRoomTypeController : ControllerBase
    {
        private readonly ISRoomTypeService _roomTypeService;

        public SRoomTypeController(ISRoomTypeService roomTypeService)
        {
            _roomTypeService = roomTypeService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SRoomTypeDto>> GetAll([FromQuery] GetAllSRoomTypeInput input)
        {
            return await _roomTypeService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<SRoomTypeDto>> GetById(Guid id)
        {
            return await _roomTypeService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<SRoomTypeDto>> CreateOrEdit(SRoomTypeDto input)
        {
            return await _roomTypeService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<SRoomTypeDto>> Delete(Guid id)
        {
            return await _roomTypeService.Delete(id);
        }
    }
}
