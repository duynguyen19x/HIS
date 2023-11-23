using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.ReceptionObjectTypes;

namespace HIS.ApplicationService.Dictionaries.ReceptionObjectTypes
{
    public interface IReceptionObjectTypeAppService : IBaseCrudAppService<ReceptionObjectTypeDto, int, GetAllReceptionObjectTypeInput>
    {
    }
}
