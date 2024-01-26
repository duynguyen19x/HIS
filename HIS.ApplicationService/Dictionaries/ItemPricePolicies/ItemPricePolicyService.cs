using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Core.Linq.Extensions;
using HIS.Dtos.Dictionaries.ItemPricePolicies;
using HIS.EntityFrameworkCore;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionaries.ItemPricePolicies
{
    public class ItemPricePolicyService : BaseCrudAppService<ItemPricePolicyDto, Guid?, GetAllItemPricePolicyInput>, IItemPricePolicyService
    {
        public ItemPricePolicyService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
           : base(dbContext, mapper)
        {

        }

        public override Task<ResultDto<ItemPricePolicyDto>> Create(ItemPricePolicyDto input)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<ItemPricePolicyDto>> Delete(Guid? id)
        {
            throw new NotImplementedException();
        }

        public override async Task<PagedResultDto<ItemPricePolicyDto>> GetAll(GetAllItemPricePolicyInput input)
        {
            var result = new PagedResultDto<ItemPricePolicyDto>();

            try
            {
                result.Result = (from r in Context.PatientTypes
                                 select new ItemPricePolicyDto()
                                 {
                                     PatientTypeId = r.Id,
                                     PatientTypeCode = r.PatientTypeCode,
                                     PatientTypeName = r.PatientTypeName,
                                     IsHeIn = r.Id == (int)HIS.Core.Enums.PatientTypes.BHYT ? true : false,
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
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public override Task<ResultDto<ItemPricePolicyDto>> GetById(Guid? id)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<ItemPricePolicyDto>> Update(ItemPricePolicyDto input)
        {
            throw new NotImplementedException();
        }
    }
}
