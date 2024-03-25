using HIS.ApplicationService.Dictionary.ServicePricePolicies.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.ServicePricePolicies
{
    public interface IServicePricePolicyService : IAppService
    {
        Task<ResultDto<ServicePricePolicyDto>> CreateOrEdit(ServicePricePolicyDto input);
        Task<ResultDto<ServicePricePolicyDto>> Delete(Guid id);
        Task<PagedResultDto<ServicePricePolicyDto>> GetAll(GetAllServicePricePolicyInput input);
        Task<ResultDto<ServicePricePolicyDto>> GetById(Guid id);
    }
}
