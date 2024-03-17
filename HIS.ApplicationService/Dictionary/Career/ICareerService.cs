using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.Career;

namespace HIS.ApplicationService.Dictionaries.Career
{
    public interface ICareerService : IBaseCrudAppService<CareerDto, Guid?, GetAllCareerInput>
    {
    }
}
