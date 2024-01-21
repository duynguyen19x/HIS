using HIS.ApplicationService.Dictionaries.Branchs;
using HIS.Core.Services.Dto;
using HIS.Dtos.Dictionaries.Branchs;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase 
    {
        private readonly IDIBranchAppService _diBranchAppService;
        public BranchController(IDIBranchAppService diBranchAppService) 
        {
            _diBranchAppService = diBranchAppService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<BranchDto>> GetAll([FromQuery] GetAllBranchInput input) => await _diBranchAppService.GetAllAsync(input);

        [HttpGet("GetById")]
        public async Task<ResultDto<BranchDto>> GetById(Guid id)  => await _diBranchAppService.GetAsync(id);

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<BranchDto>> CreateOrEdit(BranchDto input) => await _diBranchAppService.CreateOrEditAsync(input);

        [HttpDelete("Delete")]
        public async Task<ResultDto<BranchDto>> Delete(Guid id) => await _diBranchAppService.DeleteAsync(id);
    }
}
