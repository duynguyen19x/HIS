using HIS.ApplicationService.Dictionaries.Unit;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ServiceUnit;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SUnitController : ControllerBase
    {
        private readonly ISUnitService _sServiceUnitService;

        public SUnitController(ISUnitService sServiceUnitService)
        {
            _sServiceUnitService = sServiceUnitService;
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<SUnitDto>> CreateOrEdit(SUnitDto input)
        {
            return await _sServiceUnitService.CreateOrEdit(input);
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SUnitDto>> GetAll([FromQuery] GetAllSUnitInput input)
        {
            return await _sServiceUnitService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<SUnitDto>> GetById(Guid id)
        {
            return await _sServiceUnitService.GetById(id);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<SUnitDto>> Delete(Guid id)
        {
            return await _sServiceUnitService.Delete(id);
        }
    }
}
