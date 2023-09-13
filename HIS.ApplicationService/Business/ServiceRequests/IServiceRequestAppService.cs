using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Business.ServiceRequests;

namespace HIS.ApplicationService.Business.ServiceRequests
{
    public interface IServiceRequestAppService : IBaseAppService
    {
        Task<ResultDto<ServiceRequestDto>> CreateOrEdit(ServiceRequestDto input);
        Task<ResultDto<ServiceRequestDto>> Delete(Guid id);
        Task<PagedResultDto<ServiceRequestDto>> GetAll(PagedServiceRequestInputDto input);
        Task<ResultDto<ServiceRequestDto>> GetById(Guid id);
    }
}
