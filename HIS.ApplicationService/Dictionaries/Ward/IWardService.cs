using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.Ward;

namespace HIS.ApplicationService.Dictionaries.Ward
{
    public interface IWardService : IBaseDictionaryService<WardDto, GetAllWardInput>
    {
    }
}
