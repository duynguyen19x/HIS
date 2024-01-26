using HIS.Dtos.Systems.RefType;
using HIS.Dtos.Systems;
using HIS.Dtos.Dictionaries.Branchs;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

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
