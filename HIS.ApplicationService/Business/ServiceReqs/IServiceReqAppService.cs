using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Business.ServiceReqs;

namespace HIS.ApplicationService.Business.ServiceReqs
{
    public interface IServiceReqAppService : IBaseAppService
    {
        Task<ResultDto<ServiceReqDto>> CreateOrEdit(ServiceReqDto input);
        Task<ResultDto<ServiceReqDto>> Delete(Guid id);
        Task<PagedResultDto<ServiceReqDto>> GetAll(PagedServiceRequestInputDto input);
        Task<ResultDto<ServiceReqDto>> GetById(Guid id);
    }
}
