using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.Gender;

namespace HIS.ApplicationService.Dictionaries.Gender
{
    public interface IGenderService : IBaseCrudAppService<GenderDto, Guid?, GetAllGenderInput>
    {
    }
}
