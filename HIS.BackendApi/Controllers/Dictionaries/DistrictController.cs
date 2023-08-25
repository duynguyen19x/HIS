using HIS.ApplicationService.Dictionaries.District;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.District;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictController : ControllerBase
    {
        private readonly IDistrictService _districtService;

        public DistrictController(IDistrictService districtService)
        {
            _districtService = districtService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<DistrictDto>> GetAll([FromQuery] GetAllDistrictInput input)
        {
            return await _districtService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<DistrictDto>> GetById(Guid id)
        {
            return await _districtService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<DistrictDto>> CreateOrEdit(DistrictDto input)
        {
            return await _districtService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<DistrictDto>> Delete(Guid id)
        {
            return await _districtService.Delete(id);
        }
    }
}
