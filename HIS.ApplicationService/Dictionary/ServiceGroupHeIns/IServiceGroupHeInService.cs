using HIS.ApplicationService.Dictionary.ServiceGroupHeIns.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.ServiceGroupHeIns
{
    public interface IServiceGroupHeInService : IAppService
    {
        Task<ResultDto<ServiceGroupHeInDto>> CreateOrEdit(ServiceGroupHeInDto input);
        Task<ResultDto<ServiceGroupHeInDto>> Delete(Guid id);
        Task<PagedResultDto<ServiceGroupHeInDto>> GetAll(GetAllServiceGroupHeInInput input);
        Task<ResultDto<ServiceGroupHeInDto>> GetById(Guid id);
    }
}
