using HIS.ApplicationService.Dictionaries.ChapterICD10;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ChapterICD10;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SChapterIcdController : ControllerBase
    {
        private readonly ISChapterIcdService _sServiceChapterIcdService;

        public SChapterIcdController(ISChapterIcdService sServiceChapterICD10Service)
        {
            _sServiceChapterIcdService = sServiceChapterICD10Service;
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<SChapterIcdDto>> CreateOrEdit(SChapterIcdDto input)
        {
            return await _sServiceChapterIcdService.CreateOrEdit(input);
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SChapterIcdDto>> GetAll([FromQuery] GetAllSChapterIcdInput input)
        {
            return await _sServiceChapterIcdService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<SChapterIcdDto>> GetById(Guid id)
        {
            return await _sServiceChapterIcdService.GetById(id);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<SChapterIcdDto>> Delete(Guid id)
        {
            return await _sServiceChapterIcdService.Delete(id);
        }
    }
}
