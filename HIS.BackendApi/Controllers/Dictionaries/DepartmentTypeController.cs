using HIS.ApplicationService.Dictionaries.DepartmentType;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.DepartmentType;
using HIS.Models.Commons;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentTypeController : ControllerBase
    {
        private readonly IDepartmentTypeService _departmentTypeService;

        public DepartmentTypeController(IDepartmentTypeService departmentTypeService)
        {
            _departmentTypeService = departmentTypeService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<DepartmentTypeDto>> GetAll([FromQuery] GetAllDepartmentTypeInput input)
        {
            return await _departmentTypeService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ApiResult<DepartmentTypeDto>> GetById(int id)
        {
            return await _departmentTypeService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ApiResult<DepartmentTypeDto>> CreateOrEdit(DepartmentTypeDto input)
        {
            return await _departmentTypeService.CreateOrEdit(input);
        }

        [HttpPost("Delete")]
        public async Task<ApiResult<DepartmentTypeDto>> Delete(int id)
        {
            return await _departmentTypeService.Delete(id);
        }
    }
}
