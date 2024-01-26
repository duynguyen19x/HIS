using HIS.ApplicationService.Dictionaries.Districts;
using HIS.Dtos.Dictionaries.District;
using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;

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
        public async Task<PagedResultDto<DistrictDto>> GetAll([FromQuery] GetAllDistrictInput input)
        {
            return await _districtService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<DistrictDto>> GetById(Guid id)
        {
            return await _districtService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<DistrictDto>> CreateOrEdit(DistrictDto input)
        {
            return await _districtService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<DistrictDto>> Delete(Guid id)
        {
            return await _districtService.Delete(id);
        }
    }
}
