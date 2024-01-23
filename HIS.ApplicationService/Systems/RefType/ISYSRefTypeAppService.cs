using HIS.Core.Services;
using HIS.Core.Services.Dto;
using HIS.Dtos.Systems;
using HIS.Dtos.Systems.RefType;

namespace HIS.ApplicationService.Systems.RefType
{
    public interface ISYSRefTypeAppService : IAppService
    {
        Task<PagedResultDto<SYSRefTypeDto>> GetAllAsync(GetAllSYSRefTypeInputDto input);

        Task<ResultDto<SYSRefTypeDto>> GetAsync(int id);

        Task<ResultDto<SYSRefTypeDto>> CreateOrUpdateAsync(SYSRefTypeDto input);

        Task<ResultDto<SYSRefTypeDto>> DeleteAsync(int id);
    }
}
