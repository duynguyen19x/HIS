using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.Career;

namespace HIS.ApplicationService.Dictionaries.Career
{
    public interface ICareerService : IBaseDictionaryService<CareerDto, GetAllCareerInput>
    {
    }
}
