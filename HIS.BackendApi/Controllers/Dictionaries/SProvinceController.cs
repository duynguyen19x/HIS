using HIS.ApplicationService.Dictionaries.Job;
using HIS.ApplicationService.Dictionaries.Province;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Job;
using HIS.Dtos.Dictionaries.Province;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SProvinceController : ControllerBase
    {
        private readonly ISProvinceService _provinceService;

        public SProvinceController(ISProvinceService provinceService)
        {
            _provinceService = provinceService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SProvinceDto>> GetAll([FromQuery] GetAllSProvinceInput input)
        {
            return await _provinceService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<SProvinceDto>> GetById(Guid id)
        {
            return await _provinceService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<SProvinceDto>> CreateOrEdit(SProvinceDto input)
        {
            return await _provinceService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<SProvinceDto>> Delete(Guid id)
        {
            return await _provinceService.Delete(id);
        }
    }
}
