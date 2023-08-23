using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Systems.SYSRefType;

namespace HIS.ApplicationService.Systems.RefType
{
    public interface ISYSRefTypeAppService : IBaseAppService
    {
        Task<PagedResultDto<SYSRefTypeDto>> GetAll(GetAllSYSRefTypeInputDto input);
    }
}
