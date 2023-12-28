using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Business.ServiceRequestDatas;
using HIS.Dtos.Business.ServiceRequests;
using HIS.Dtos.Business.ServiceResultDatas;
using HIS.Utilities.Enums;

namespace HIS.ApplicationService.Business.Testings
{
    public interface ITestingService
    {
        Task<PagedResultDto<ServiceRequestDto>> GetAll(GetAllServiceRequestInputDto input);
        Task<ListResultDto<ServiceRequestDataDto>> GetServiceRequestDataByServiceRequestId(Guid serviceRequestId, GenderTypes genderType, bool isDetail = true);
        Task<ListResultDto<ServiceResultDataDto>> GetServiceResultDataByServiceRequestDataId(Guid serviceRequestDataId, GenderTypes genderType);
        Task<ListResultDto<ServiceResultDataDto>> GetServiceResultDataByServiceRequestId(Guid serviceRequestId, GenderTypes genderType);
    }
}
