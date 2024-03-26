using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.Machines;

namespace HIS.ApplicationService.Dictionaries.Machines
{
    public interface IMachineService : IAppService
    {
        Task<ResultDto<MachineDto>> CreateOrEdit(MachineDto input);
        Task<ResultDto<MachineDto>> Delete(Guid id);
        Task<PagedResultDto<MachineDto>> GetAll(GetAllMachineInput input);
        Task<ResultDto<MachineDto>> GetById(Guid id);
    }
}
