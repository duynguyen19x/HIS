using HIS.ApplicationService.Dictionaries.Department;
using HIS.Dtos.Dictionaries.Department;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet("GetAll")]
        [Authorize]
        public async Task<PagedResultDto<DepartmentDto>> GetAll([FromQuery] GetAllDepartmentInput input)
        {
            return await _departmentService.GetAll(input);
        }

        [HttpGet("GetById")]
        [Authorize]
        public async Task<ResultDto<DepartmentDto>> GetById(Guid id)
        {
            return await _departmentService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        [Authorize]
        public async Task<ResultDto<DepartmentDto>> CreateOrEdit(DepartmentDto input)
        {
            return await _departmentService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        [Authorize]
        public async Task<ResultDto<DepartmentDto>> Delete(Guid id)
        {
            return await _departmentService.Delete(id);
        }
    }
}
