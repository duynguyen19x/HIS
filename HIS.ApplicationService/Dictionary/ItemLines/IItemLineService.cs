using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.ItemLines;

namespace HIS.ApplicationService.Dictionaries.ItemLines
{
    public interface IItemLineService : IBaseCrudAppService<ItemLineDto, Guid?, GetAllItemLineInput>
    {
    }
}
