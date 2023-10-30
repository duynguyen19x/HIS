using HIS.Application.Core.Services.Dto;
using HIS.ApplicationService.Dictionaries.ColumnTemplates;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ColumnTemplates;
using HIS.Dtos.Dictionaries.ItemLines;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColumnTemplateController : ControllerBase
    {
        private readonly IColumnTemplateAppService _columnTemplateAppService;

        public ColumnTemplateController(IColumnTemplateAppService columnTemplateAppService)
        {
            _columnTemplateAppService = columnTemplateAppService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<ColumnTemplateDto>> GetAll([FromQuery] PagedColumnTemplateResultRequestDto input)
        {
            return await _columnTemplateAppService.GetAll(input);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<ColumnTemplateDto>> CreateOrEdit(CreateOrEditColumnTemplateDto input)
        {
            return await _columnTemplateAppService.CreateOrEdit(input);
        }
    }
}
