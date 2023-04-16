using HIS.ApplicationService.Dictionaries.Branch;
using HIS.ApplicationService.Systems.Role;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Branch;
using HIS.Dtos.Systems.Role;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly IBranchService _branchService;

        public BranchController(IBranchService branchService)
        {
            _branchService = branchService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SBranchDto>> GetAll([FromQuery] GetAllSBranchInput input)
        {
            return await _branchService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<SBranchDto>> GetById(Guid id)
        {
            return await _branchService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<SBranchDto>> CreateOrEdit(SBranchDto input)
        {
            return await _branchService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<SBranchDto>> Delete(Guid input)
        {
            return await _branchService.Delete(input);
        }
    }
}
