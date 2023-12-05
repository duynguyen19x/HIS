using HIS.Application.Core.Services.Dto;
using HIS.ApplicationService.Dictionaries.ChapterICD10;
using HIS.Dtos.Dictionaries.ChapterICD10;
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
        public async Task<ResultDto<ChapterIcdDto>> CreateOrEdit(ChapterIcdDto input)
        {
            return await _sServiceChapterIcdService.CreateOrEdit(input);
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<ChapterIcdDto>> GetAll([FromQuery] GetAllChapterIcdInput input)
        {
            return await _sServiceChapterIcdService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<ChapterIcdDto>> GetById(Guid id)
        {
            return await _sServiceChapterIcdService.GetById(id);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<ChapterIcdDto>> Delete(Guid id)
        {
            return await _sServiceChapterIcdService.Delete(id);
        }
    }
}
