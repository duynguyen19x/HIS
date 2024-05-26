using HIS.Dtos.Dictionaries.Branchs;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.ApplicationService.Dictionary.Branchs.Dto;

namespace HIS.ApplicationService.Dictionary.Branchs
{
    public interface IBranchAppService : IAppService
    {
        Task<PagedResultDto<BranchDto>> GetAll(GetAllBranchInputDto input);

        Task<ResultDto<BranchDto>> Get(Guid id);

        Task<ResultDto<BranchDto>> CreateOrEdit(BranchDto input);

        Task<ResultDto<BranchDto>> Delete(Guid id);
    }
}
