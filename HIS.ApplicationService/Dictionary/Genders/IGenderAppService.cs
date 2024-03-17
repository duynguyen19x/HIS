using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.Genders;

namespace HIS.ApplicationService.Dictionaries.Genders
{
    public interface IGenderAppService : IBaseCrudAppService<GenderDto, Guid?, GetAllGenderInput>
    {
    }
}
