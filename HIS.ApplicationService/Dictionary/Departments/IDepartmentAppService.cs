using HIS.Application.Core.Services;
using HIS.ApplicationService.Dictionary.Branchs.Dto;
using HIS.ApplicationService.Dictionary.Departments.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.Branchs;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.Departments
{
    public interface IDepartmentAppService : IAppService
    {
        Task<PagedResultDto<DepartmentDto>> GetAllAsync(GetAllDepartmentInputDto input);

        Task<ResultDto<DepartmentDto>> GetAsync(Guid id);

        Task<ResultDto<DepartmentDto>> CreateOrUpdateAsync(DepartmentDto input);

        Task<ResultDto<DepartmentDto>> DeleteAsync(Guid id);
    }
}
