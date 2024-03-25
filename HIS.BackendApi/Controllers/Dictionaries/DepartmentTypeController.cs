using Microsoft.AspNetCore.Mvc;
using HIS.Core.Application.Services.Dto;
using HIS.ApplicationService.Dictionary.DepartmentTypes;
using HIS.ApplicationService.Dictionary.DepartmentTypes.Dto;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentTypeController : ControllerBase
    {
        private readonly IDepartmentTypeAppService _departmentTypeService;

        public DepartmentTypeController(IDepartmentTypeAppService departmentTypeService)
        {
            _departmentTypeService = departmentTypeService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<DepartmentTypeDto>> GetAll([FromQuery] GetAllDepartmentTypeInputDto input)
        {
            return await _departmentTypeService.GetAllAsync(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<DepartmentTypeDto>> GetById(int id)
        {
            return await _departmentTypeService.GetAsync(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<DepartmentTypeDto>> CreateOrEdit(DepartmentTypeDto input)
        {
            return await _departmentTypeService.CreateOrUpdateAsync(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<DepartmentTypeDto>> Delete(int id)
        {
            return await _departmentTypeService.DeleteAsync(id);
        }
    }
}
