using HIS.ApplicationService.Dictionaries.Department;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Department;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ApiResultList<DepartmentDto>> GetAll([FromQuery] GetAllDepartmentInput input)
        {
            return await _departmentService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<DepartmentDto>> GetById(Guid id)
        {
            return await _departmentService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<DepartmentDto>> CreateOrEdit(DepartmentDto input)
        {
            return await _departmentService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<DepartmentDto>> Delete(Guid id)
        {
            return await _departmentService.Delete(id);
        }
    }
}
