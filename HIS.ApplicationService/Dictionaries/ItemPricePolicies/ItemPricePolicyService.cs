using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ItemPricePolicies;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using HIS.Utilities.Enums;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.ItemPricePolicies
{
    public class ItemPricePolicyService : BaseSerivce, IItemPricePolicyService
    {
        public ItemPricePolicyService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
           : base(dbContext, config, mapper)
        {

        }

        public Task<ApiResult<ItemPricePolicyDto>> CreateOrEdit(ItemPricePolicyDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<ItemPricePolicyDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResultList<ItemPricePolicyDto>> GetAll(GetAllItemPricePolicyInput input)
        {
            var result = new ApiResultList<ItemPricePolicyDto>();

            try
            {
                result.Result = (from r in _dbContext.PatientTypes
                                 select new ItemPricePolicyDto()
                                 {
                                     PatientTypeId = r.Id,
                                     PatientTypeCode = r.Code,
                                     PatientTypeName = r.Name,
                                     IsHeIn = r.Code == PatientTypes.BHYT ? true : false,
                                     Inactive = r.Inactive,
                                 })
                                 .WhereIf(input.InactiveFilter != null, w => w.Inactive == input.InactiveFilter)
                                 .WhereIf(!GuidHelper.IsNullOrEmpty(input.ItemIdFilter), w => w.ItemId == input.ItemIdFilter)
                                 .WhereIf(input.PatientTypeIdFilter != null, w => w.PatientTypeId == input.PatientTypeIdFilter)
                                 .OrderBy(o => o.PatientTypeCode).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public Task<ApiResult<ItemPricePolicyDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
