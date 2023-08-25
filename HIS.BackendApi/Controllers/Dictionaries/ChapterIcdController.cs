using HIS.ApplicationService.Dictionaries.ChapterICD10;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ChapterICD10;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChapterIcdController : ControllerBase
    {
        private readonly IChapterIcdService _sServiceChapterIcdService;

        public ChapterIcdController(IChapterIcdService sServiceChapterICD10Service)
        {
            _sServiceChapterIcdService = sServiceChapterICD10Service;
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<ChapterIcdDto>> CreateOrEdit(ChapterIcdDto input)
        {
            return await _sServiceChapterIcdService.CreateOrEdit(input);
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<ChapterIcdDto>> GetAll([FromQuery] GetAllChapterIcdInput input)
        {
            return await _sServiceChapterIcdService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<ChapterIcdDto>> GetById(Guid id)
        {
            return await _sServiceChapterIcdService.GetById(id);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<ChapterIcdDto>> Delete(Guid id)
        {
            return await _sServiceChapterIcdService.Delete(id);
        }
    }
}
