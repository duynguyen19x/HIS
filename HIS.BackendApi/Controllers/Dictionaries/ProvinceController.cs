using HIS.ApplicationService.Dictionaries.Provinces;
using HIS.Dtos.Dictionaries.Province;
using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {
        private readonly IProvinceAppService _provinceService;

        public ProvinceController(IProvinceAppService provinceService)
        {
            _provinceService = provinceService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<ProvinceDto>> GetAll([FromQuery] GetAllProvinceInputDto input)
        {
            return await _provinceService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<ProvinceDto>> GetById(Guid id)
        {
            return await _provinceService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<ProvinceDto>> CreateOrEdit(ProvinceDto input)
        {
            return await _provinceService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<ProvinceDto>> Delete(Guid id)
        {
            return await _provinceService.Delete(id);
        }
    }
}
