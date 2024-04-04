using HIS.ApplicationService.Dictionary.Branchs;
using HIS.ApplicationService.Dictionary.Branchs.Dto;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.Branchs;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase 
    {
        private readonly IBranchAppService _diBranchAppService;

        public BranchController(IBranchAppService diBranchAppService) 
        {
            _diBranchAppService = diBranchAppService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<BranchDto>> GetAll([FromQuery] GetAllBranchInputDto input) => await _diBranchAppService.GetAllAsync(input);

        [HttpGet("GetById")]
        public async Task<ResultDto<BranchDto>> GetById(Guid id)  => await _diBranchAppService.GetAsync(id);

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<BranchDto>> CreateOrEdit(BranchDto input) => await _diBranchAppService.CreateOrUpdateAsync(input);

        [HttpDelete("Delete")]
        public async Task<ResultDto<BranchDto>> Delete(Guid id) => await _diBranchAppService.DeleteAsync(id);
    }
}
