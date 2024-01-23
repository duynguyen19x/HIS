using HIS.Core.Services.Dto;
using HIS.Dtos.Systems.RefType;
using HIS.Dtos.Systems;
using HIS.Core.Services;
using HIS.Dtos.Dictionaries.Branchs;

namespace HIS.ApplicationService.Dictionaries.Branchs
{
    public interface IDIBranchAppService : IAppService
    {
        Task<PagedResultDto<DIBranchDto>> GetAllAsync(GetAllDIBranchInputDto input);

        Task<ResultDto<DIBranchDto>> GetAsync(Guid id);

        Task<ResultDto<DIBranchDto>> CreateOrUpdateAsync(DIBranchDto input);

        Task<ResultDto<DIBranchDto>> DeleteAsync(Guid id);
    }
}
