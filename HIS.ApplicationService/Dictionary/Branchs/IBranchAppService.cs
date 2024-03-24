using HIS.Dtos.Dictionaries.Branchs;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.ApplicationService.Dictionary.Branchs.Dto;

namespace HIS.ApplicationService.Dictionary.Branchs
{
    public interface IBranchAppService : IAppService
    {
        Task<PagedResultDto<BranchDto>> GetAllAsync(GetAllBranchInputDto input);

        Task<ResultDto<BranchDto>> GetAsync(Guid id);

        Task<ResultDto<BranchDto>> CreateOrUpdateAsync(BranchDto input);

        Task<ResultDto<BranchDto>> DeleteAsync(Guid id);
    }
}
