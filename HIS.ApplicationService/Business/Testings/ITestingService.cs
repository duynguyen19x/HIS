using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Business.ServiceRequestDatas;
using HIS.Dtos.Business.ServiceRequests;
using HIS.Dtos.Business.ServiceResultDatas;
using HIS.Utilities.Enums;

namespace HIS.ApplicationService.Business.Testings
{
    public interface ITestingService
    {
        Task<PagedResultDto<ServiceRequestDto>> GetAll(GetAllServiceRequestInputDto input);
        Task<ResultDto<ServiceRequestDto>> GetServiceRequestById(Guid serviceRequestId, GenderTypes gender, bool isDetail = true);
        Task<ListResultDto<ServiceRequestDetailDto>> GetServiceRequestDetailByServiceRequestId(Guid serviceRequestId, GenderTypes genderType, bool isDetail = true);
        Task<ListResultDto<ServiceRequestDetailResultDto>> GetServiceRequestDetailResultByServiceRequestDetailId(Guid serviceRequestDataId, GenderTypes genderType);
        Task<ListResultDto<ServiceRequestDetailResultDto>> GetServiceRequestDetailResultByServiceRequestId(Guid serviceRequestId, GenderTypes genderType);

        Task<ResultDto<ServiceRequestDto>> UpdateTestingStatus(ServiceRequestDto input);
        Task<ResultDto<ServiceRequestDto>> UpdateTestingCancelStatus(ServiceRequestDto input);
    }
}
