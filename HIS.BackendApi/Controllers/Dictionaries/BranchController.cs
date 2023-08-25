using HIS.ApplicationService.Dictionaries.Branch;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Branch;
using HIS.Models.Commons;
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
        public async Task<ApiResultList<BranchDto>> GetAll([FromQuery] GetAllBranchInput input)
        {
            return await _branchService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<BranchDto>> GetById(Guid id)
        {
            return await _branchService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<BranchDto>> CreateOrEdit(BranchDto input)
        {
            return await _branchService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<BranchDto>> Delete(Guid id)
        {
            return await _branchService.Delete(id);
        }
    }
}
