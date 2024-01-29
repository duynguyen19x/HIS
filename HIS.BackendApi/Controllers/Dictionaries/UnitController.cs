using HIS.Core.Services.Dto;
using HIS.ApplicationService.Dictionaries.Unit;
using HIS.Dtos.Dictionaries.ServiceUnit;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private readonly IUnitService _sServiceUnitService;

        public UnitController(IUnitService sServiceUnitService)
        {
            _sServiceUnitService = sServiceUnitService;
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<UnitDto>> CreateOrEdit(UnitDto input)
        {
            return await _sServiceUnitService.CreateOrEdit(input);
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<UnitDto>> GetAll([FromQuery] GetAllUnitInput input)
        {
            return await _sServiceUnitService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<UnitDto>> GetById(Guid id)
        {
            return await _sServiceUnitService.GetById(id);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<UnitDto>> Delete(Guid id)
        {
            return await _sServiceUnitService.Delete(id);
        }
    }
}
