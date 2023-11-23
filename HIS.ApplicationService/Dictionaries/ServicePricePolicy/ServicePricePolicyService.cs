using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ServicePricePolicy;
using HIS.EntityFrameworkCore;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.ServicePricePolicy
{
    public class ServicePricePolicyService : BaseSerivce, IServicePricePolicyService
    {
        public ServicePricePolicyService(HISDbContext dbContext, IConfiguration config, IMapper mapper) : base(dbContext, config, mapper)
        {

        }

        public Task<ApiResult<ServicePricePolicyDto>> CreateOrEdit(ServicePricePolicyDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<ServicePricePolicyDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResultList<ServicePricePolicyDto>> GetAll(GetAllServicePricePolicyInput input)
        {
            var result = new ApiResultList<ServicePricePolicyDto>();

            try
            {
                result.Result = (from r in _dbContext.PatientObjectTypes
                                 select new ServicePricePolicyDto()
                                 {
                                     PatientObjectTypeId = r.Id,
                                     PatientObjectTypeCode = r.PatientObjectTypeCode,
                                     PatientObjectTypeName = r.PatientObjectTypeName,
                                     Inactive = r.Inactive,
                                 })
                                 .WhereIf(input.InactiveFilter != null, w => w.Inactive == input.InactiveFilter)
                                 .OrderBy(o => o.PatientObjectTypeCode).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public Task<ApiResult<ServicePricePolicyDto>> GetById(Guid serviceId)
        {
            throw new NotImplementedException();
        }
    }
}
