using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ServicePricePolicy;
using HIS.EntityFrameworkCore.DbContexts;
using HIS.Models.Commons;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.ServicePricePolicy
{
    public class SServicePricePolicyService : BaseSerivce, ISServicePricePolicyService
    {
        public SServicePricePolicyService(HIS_DbContext dbContext, IConfiguration config) : base(dbContext, config)
        {

        }

        public Task<ApiResult<SServicePricePolicyDto>> CreateOrEdit(SServicePricePolicyDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<SServicePricePolicyDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResultList<SServicePricePolicyDto>> GetAll(GetAllSServicePricePolicyInput input)
        {
            var result = new ApiResultList<SServicePricePolicyDto>();

            try
            {
                result.Result = (from r in _dbContext.SPatientTypes
                                 where (input.InactiveFilter == null || r.Inactive == !input.InactiveFilter)
                                 select new SServicePricePolicyDto()
                                 {
                                     PatientTypeId = r.Id,
                                     PatientTypeCode = r.Code,
                                     PatientTypeName = r.Name,
                                 }).OrderBy(o => o.PatientTypeCode).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public Task<ApiResult<SServicePricePolicyDto>> GetById(Guid serviceId)
        {
            throw new NotImplementedException();
        }
    }
}
