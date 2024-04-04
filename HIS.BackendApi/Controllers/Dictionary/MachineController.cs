using HIS.ApplicationService.Dictionaries.Machines;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.Machines;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class MachineController : ControllerBase
    {
        private readonly IMachineService _machineService;

        public MachineController(IMachineService machineService)
        {
            _machineService = machineService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<MachineDto>> GetAll([FromQuery] GetAllMachineInput input)
        {
            return await _machineService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<MachineDto>> GetById(Guid id)
        {
            return await _machineService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<MachineDto>> CreateOrEdit(MachineDto input)
        {
            return await _machineService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<MachineDto>> Delete(Guid id)
        {
            return await _machineService.Delete(id);
        }
    }
}
