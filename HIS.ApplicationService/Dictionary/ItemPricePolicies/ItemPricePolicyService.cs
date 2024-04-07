using AutoMapper;
using HIS.Dtos.Dictionaries.ItemPricePolicies;
using HIS.EntityFrameworkCore;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;
using HIS.Core.Application.Services;
using HIS.Core.Domain.Repositories;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Items;
using HIS.Dtos.Dictionaries.ItemLines;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.Dictionary;

namespace HIS.ApplicationService.Dictionary.ItemPricePolicies
{
    public class ItemPricePolicyService : BaseAppService, IItemPricePolicyService
    {
        private readonly IRepository<ItemPricePolicy, Guid> _itemPricePolicyRepository;
        private readonly IRepository<PatientObjectType, int> _patientObjectTypeRepository;

        public ItemPricePolicyService(
            IRepository<ItemPricePolicy, Guid> itemPricePolicyRepository,
            IRepository<PatientObjectType, int> patientObjectTypeRepository)
        {
            _itemPricePolicyRepository = itemPricePolicyRepository;
            _patientObjectTypeRepository = patientObjectTypeRepository;
        }

        public virtual async Task<ResultDto<ItemPricePolicyDto>> CreateOrEdit(ItemPricePolicyDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public virtual Task<ResultDto<ItemPricePolicyDto>> Create(ItemPricePolicyDto input)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ResultDto<ItemPricePolicyDto>> Update(ItemPricePolicyDto input)
        {
            throw new NotImplementedException();
        }

        public virtual Task<ResultDto<ItemPricePolicyDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<PagedResultDto<ItemPricePolicyDto>> GetAll(GetAllItemPricePolicyInput input)
        {
            var result = new PagedResultDto<ItemPricePolicyDto>();

            try
            {
                result.Result = (from r in _patientObjectTypeRepository.GetAll()
                                 select new ItemPricePolicyDto()
                                 {
                                     PatientTypeId = r.Id,
                                     PatientTypeCode = r.Code,
                                     PatientTypeName = r.Name,
                                     IsHeIn = r.Id == (int)HIS.Core.Enums.DIPatientObjectType.BH ? true : false,
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

        public virtual Task<ResultDto<ItemPricePolicyDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        
    }
}
