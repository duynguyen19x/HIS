using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.ServiceUnit;

namespace HIS.ApplicationService.Dictionaries.Unit
{
    public interface IUnitService : IBaseCrudAppService<UnitDto, Guid?, GetAllUnitInput>
    {
    } 
}
