using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Business.ServiceRequests;

namespace HIS.ApplicationService.Business.Testings
{
    public interface ITestingService
    {
        Task<PagedResultDto<ServiceRequestDto>> GetAll(GetAllServiceRequestInputDto input);
    }
}
