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
        public async Task<PagedResultDto<DIBranchDto>> GetAll([FromQuery] GetAllDIBranchInputDto input) => await _diBranchAppService.GetAllAsync(input);

        [HttpGet("GetById")]
        public async Task<ResultDto<DIBranchDto>> GetById(Guid id)  => await _diBranchAppService.GetAsync(id);

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<DIBranchDto>> CreateOrEdit(DIBranchDto input) => await _diBranchAppService.CreateOrUpdateAsync(input);

        [HttpDelete("Delete")]
        public async Task<ResultDto<DIBranchDto>> Delete(Guid id) => await _diBranchAppService.DeleteAsync(id);
    }
}
