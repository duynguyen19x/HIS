using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.SurgicalProcedureType;

namespace HIS.ApplicationService.Dictionaries.SurgicalProcedureType
{
    public interface ISurgicalProcedureTypeService : IBaseCrudAppService<SSurgicalProcedureTypeDto, int?, GetAllSurgicalProcedureTypeInput>
    {
    }
}
