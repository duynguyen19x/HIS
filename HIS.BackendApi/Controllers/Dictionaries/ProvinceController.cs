using HIS.ApplicationService.Dictionaries.Province;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Province;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {
        private readonly IProvinceService _provinceService;

        public ProvinceController(IProvinceService provinceService)
        {
            _provinceService = provinceService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<ProvinceDto>> GetAll([FromQuery] GetAllProvinceInput input)
        {
            return await _provinceService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<ProvinceDto>> GetById(Guid id)
        {
            return await _provinceService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<ProvinceDto>> CreateOrEdit(ProvinceDto input)
        {
            return await _provinceService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<ProvinceDto>> Delete(Guid id)
        {
            return await _provinceService.Delete(id);
        }
    }
}
