using HIS.ApplicationService.Dictionary.ServiceGroups.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.ServiceGroups
{
    public interface IServiceGroupService : IAppService
    {
        Task<ResultDto<ServiceGroupDto>> CreateOrEdit(ServiceGroupDto input);
        Task<ResultDto<ServiceGroupDto>> Delete(Guid id);
        Task<PagedResultDto<ServiceGroupDto>> GetAll(GetAllServiceGroupInput input);
        Task<ResultDto<ServiceGroupDto>> GetById(Guid id);
    }
}
