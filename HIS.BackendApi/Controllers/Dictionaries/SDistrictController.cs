using HIS.ApplicationService.Dictionaries.District;
using HIS.ApplicationService.Dictionaries.Job;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.District;
using HIS.Dtos.Dictionaries.Job;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SDistrictController : ControllerBase
    {
        private readonly ISDistrictService _districtService;

        public SDistrictController(ISDistrictService districtService)
        {
            _districtService = districtService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SDistrictDto>> GetAll([FromQuery] GetAllSDistrictInput input)
        {
            return await _districtService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<SDistrictDto>> GetById(Guid id)
        {
            return await _districtService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<SDistrictDto>> CreateOrEdit(SDistrictDto input)
        {
            return await _districtService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<SDistrictDto>> Delete(Guid id)
        {
            return await _districtService.Delete(id);
        }
    }
}
