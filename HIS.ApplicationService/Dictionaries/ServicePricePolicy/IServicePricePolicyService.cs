using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.ServicePricePolicy;

namespace HIS.ApplicationService.Dictionaries.ServicePricePolicy
{
    public interface IServicePricePolicyService : IBaseCrudAppService<ServicePricePolicyDto, Guid?, GetAllServicePricePolicyInput>
    {

    }
}
