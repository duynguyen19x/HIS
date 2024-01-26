using HIS.ApplicationService.Dictionaries.DepartmentType;
using HIS.Dtos.Dictionaries.DepartmentType;
using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;

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
        public async Task<PagedResultDto<DepartmentTypeDto>> GetAll([FromQuery] GetAllDepartmentTypeInput input)
        {
            return await _departmentTypeService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<DepartmentTypeDto>> GetById(int id)
        {
            return await _departmentTypeService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<DepartmentTypeDto>> CreateOrEdit(DepartmentTypeDto input)
        {
            return await _departmentTypeService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<DepartmentTypeDto>> Delete(int id)
        {
            return await _departmentTypeService.Delete(id);
        }
    }
}
