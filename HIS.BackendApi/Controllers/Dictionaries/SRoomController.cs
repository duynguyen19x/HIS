using HIS.ApplicationService.Dictionaries.Department;
using HIS.ApplicationService.Dictionaries.Room;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Department;
using HIS.Dtos.Dictionaries.Room;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SRoomController : ControllerBase
    {
        private readonly ISRoomService _roomService;

        public SRoomController(ISRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SRoomDto>> GetAll([FromQuery] GetAllSRoomInput input)
        {
            return await _roomService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<SRoomDto>> GetById(Guid id)
        {
            return await _roomService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<SRoomDto>> CreateOrEdit(SRoomDto input)
        {
            return await _roomService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<SRoomDto>> Delete(Guid input)
        {
            return await _roomService.Delete(input);
        }
    }
}
