using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.Machines;

namespace HIS.ApplicationService.Dictionaries.Machines
{
    public interface IMachineService : IBaseCrudAppService<MachineDto, Guid?, GetAllMachineInput>
    {
    }
}
