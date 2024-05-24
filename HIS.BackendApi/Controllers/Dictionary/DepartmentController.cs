using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;
using HIS.ApplicationService.Dictionary.Departments;
using HIS.ApplicationService.Dictionary.Departments.Dto;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IdepartmentAppService _departmentService;

        public DepartmentController(IdepartmentAppService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet("GetAll")]
        //[Authorize]
        public async Task<PagedResultDto<DepartmentDto>> GetAll([FromQuery] GetAllDepartmentInputDto input)
        {
            return await _departmentService.GetAllAsync(input);
        }

        [HttpGet("GetById")]
        //[Authorize]
        public async Task<ResultDto<DepartmentDto>> GetById(Guid id)
        {
            return await _departmentService.GetAsync(id);
        }

        [HttpPost("CreateOrEdit")]
        //[Authorize]
        public async Task<ResultDto<DepartmentDto>> CreateOrEdit(DepartmentDto input)
        {
            return await _departmentService.CreateOrUpdateAsync(input);
        }

        [HttpDelete("Delete")]
        //[Authorize]
        public async Task<ResultDto<DepartmentDto>> Delete(Guid id)
        {
            return await _departmentService.DeleteAsync(id);
        }
    }
}
