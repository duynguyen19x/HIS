using HIS.ApplicationService.Dictionary.SurgicalProcedureTypes.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.SurgicalProcedureTypes
{
    public interface ISurgicalProcedureTypeAppService : IAppService
    {
        Task<ResultDto<SSurgicalProcedureTypeDto>> CreateOrEdit(SSurgicalProcedureTypeDto input);
        Task<ResultDto<SSurgicalProcedureTypeDto>> Delete(int id);
        Task<PagedResultDto<SSurgicalProcedureTypeDto>> GetAll(GetAllSurgicalProcedureTypeInput input);
        Task<ResultDto<SSurgicalProcedureTypeDto>> GetById(int id);
    }
}
