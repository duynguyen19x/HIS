using HIS.ApplicationService.Dictionaries.ServiceGroupHeIn;
using HIS.ApplicationService.Dictionaries.ServiceUnit;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ServiceGroupHeIn;
using HIS.Dtos.Dictionaries.ServiceUnit;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SServiceUnitController : ControllerBase
    {
        private readonly ISServiceUnitService _sServiceUnitService;

        public SServiceUnitController(ISServiceUnitService sServiceUnitService)
        {
            _sServiceUnitService = sServiceUnitService;
        }

        [HttpGet("CreateOrEdit")]
        public async Task<ApiResult<SServiceUnitDto>> CreateOrEdit(SServiceUnitDto input)
        {
            return await _sServiceUnitService.CreateOrEdit(input);
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SServiceUnitDto>> GetAll([FromQuery] GetAllSServiceUnitInput input)
        {
            return await _sServiceUnitService.GetAll(input);
        }

        [HttpDelete("GetById")]
        public async Task<ApiResult<SServiceUnitDto>> GetById(Guid id)
        {
            return await _sServiceUnitService.GetById(id);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<SServiceUnitDto>> Delete(Guid id)
        {
            return await _sServiceUnitService.Delete(id);
        }
    }
}
