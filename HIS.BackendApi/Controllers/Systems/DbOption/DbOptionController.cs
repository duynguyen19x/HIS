using HIS.ApplicationService.Dictionaries.Icd;
using HIS.ApplicationService.Systems.DbOption;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Icd;
using HIS.Dtos.Systems.DbOption;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Systems.DbOption
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbOptionController : ControllerBase
    {
        private readonly IDbOptionAppService _iDbOptionAppService;

        public DbOptionController(IDbOptionAppService iDbOptionAppService)
        {
            _iDbOptionAppService = iDbOptionAppService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<DbOptionDto>> GetAll([FromQuery] GetAllDbOptionInput input)
        {
            return await _iDbOptionAppService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<DbOptionDto>> GetById(Guid id)
        {
            return await _iDbOptionAppService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<DbOptionDto>> CreateOrEdit(DbOptionDto input)
        {
            return await _iDbOptionAppService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<DbOptionDto>> Delete(Guid id)
        {
            return await _iDbOptionAppService.Delete(id);
        }
    }
}
