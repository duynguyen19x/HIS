using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.ItemLines;

namespace HIS.ApplicationService.Dictionaries.ItemLines
{
    public interface IItemLineService : IBaseDictionaryService<ItemLineDto, GetAllItemLineInput>
    {
    }
}
