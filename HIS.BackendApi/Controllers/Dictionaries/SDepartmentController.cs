using HIS.ApplicationService.Dictionaries.Department;
using HIS.ApplicationService.Dictionaries.Room;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Department;
using HIS.Dtos.Dictionaries.Room;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SDepartmentController : ControllerBase
    {
        private readonly ISDepartmentService _departmentService;

        public SDepartmentController(ISDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SDepartmentDto>> GetAll([FromQuery] GetAllSDepartmentInput input)
        {
            return await _departmentService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<SDepartmentDto>> GetById(Guid id)
        {
            return await _departmentService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<SDepartmentDto>> CreateOrEdit(SDepartmentDto input)
        {
            return await _departmentService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ApiResult<SDepartmentDto>> Delete(Guid id)
        {
            return await _departmentService.Delete(id);
        }
    }
}
