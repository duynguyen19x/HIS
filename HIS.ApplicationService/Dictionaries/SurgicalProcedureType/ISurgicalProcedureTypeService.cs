using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.SurgicalProcedureType;

namespace HIS.ApplicationService.Dictionaries.SurgicalProcedureType
{
    public interface ISurgicalProcedureTypeService : IBaseDictionaryService<SSurgicalProcedureTypeDto, GetAllSurgicalProcedureTypeInput, int>
    {
    }
}
