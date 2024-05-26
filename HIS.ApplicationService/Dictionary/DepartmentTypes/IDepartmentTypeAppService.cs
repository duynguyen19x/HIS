using HIS.ApplicationService.Dictionary.DepartmentTypes.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.DepartmentTypes
{
    public interface IdepartmentTypeAppService : IAppService
    {
        Task<ResultDto<DepartmentTypeDto>> CreateOrUpdateAsync(DepartmentTypeDto input);
        Task<ResultDto<DepartmentTypeDto>> DeleteAsync(int id);
        Task<PagedResultDto<DepartmentTypeDto>> GetAllAsync(GetAllDepartmentTypeInputDto input);
        Task<ResultDto<DepartmentTypeDto>> GetAsync(int id);
    }
}
