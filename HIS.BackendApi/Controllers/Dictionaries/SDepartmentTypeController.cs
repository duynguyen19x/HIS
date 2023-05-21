using HIS.ApplicationService.Dictionaries.Department;
using HIS.ApplicationService.Dictionaries.DepartmentType;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Department;
using HIS.Dtos.Dictionaries.DepartmentType;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class SDepartmentTypeController : ControllerBase
    {
        private readonly ISDepartmentTypeService _departmentTypeService;

        public SDepartmentTypeController(ISDepartmentTypeService departmentTypeService)
        {
            _departmentTypeService = departmentTypeService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<SDepartmentTypeDto>> GetAll([FromQuery] GetAllSDepartmentTypeInput input)
        {
            return await _departmentTypeService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<SDepartmentTypeDto>> GetById(Guid id)
        {
            return await _departmentTypeService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<SDepartmentTypeDto>> CreateOrEdit(SDepartmentTypeDto input)
        {
            return await _departmentTypeService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<SDepartmentTypeDto>> Delete(Guid id)
        {
            return await _departmentTypeService.Delete(id);
        }
    }
}
