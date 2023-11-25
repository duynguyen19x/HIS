using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.ReceptionTypes;

namespace HIS.ApplicationService.Dictionaries.ReceptionTypes
{
    public interface IReceptionTypeAppService : IBaseCrudAppService<ReceptionTypeDto, int, GetAllReceptionTypeInput>
    {
    }
}
