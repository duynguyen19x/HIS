using HIS.Dtos.Dictionaries.Icd;
using HIS.Application.Core.Services;

namespace HIS.ApplicationService.Dictionaries.Icds
{
    public interface IIcdService : IBaseCrudAppService<IcdDto, Guid?, GetAllIcdInput>
    {
    }
}
