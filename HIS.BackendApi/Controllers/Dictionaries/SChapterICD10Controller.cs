using HIS.ApplicationService.Dictionaries.ChapterICD10;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ChapterICD10;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SChapterICD10Controller : ControllerBase
    {
        private readonly ISChapterICD10Service _sServiceChapterICD10Service;

        public SChapterICD10Controller(ISChapterICD10Service sServiceChapterICD10Service)
        {
            _sServiceChapterICD10Service = sServiceChapterICD10Service;
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<SChapterICD10Dto>> CreateOrEdit(SChapterICD10Dto input)
        {
            return await _sServiceChapterICD10Service.CreateOrEdit(input);
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SChapterICD10Dto>> GetAll([FromQuery] GetAllSChapterICD10Input input)
        {
            return await _sServiceChapterICD10Service.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<SChapterICD10Dto>> GetById(Guid id)
        {
            return await _sServiceChapterICD10Service.GetById(id);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<SChapterICD10Dto>> Delete(Guid id)
        {
            return await _sServiceChapterICD10Service.Delete(id);
        }
    }
}
