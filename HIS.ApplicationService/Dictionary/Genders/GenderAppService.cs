using AutoMapper;
using HIS.ApplicationService.Dictionary.Districts.Dto;
using HIS.ApplicationService.Dictionary.Genders.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Transactions;

namespace HIS.ApplicationService.Dictionary.Genders
{
    public class GenderAppService : BaseAppService, IGenderAppService
    {
        private readonly IRepository<Gender, int> _genderRepository;

        public GenderAppService(IRepository<Gender, int> genderRepository)
        {
            _genderRepository = genderRepository;
        }

        public virtual async Task<PagedResultDto<GenderDto>> GetAll(GetAllGenderInputDto input)
        {
            var result = new PagedResultDto<GenderDto>();
            try
            {
                var filter = _genderRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code == input.CodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name == input.NameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                if (Check.IsNullOrDefault(input.Sorting))
                    input.Sorting = "SortOrder";

                var paged = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<GenderDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return result;
        }

        public virtual async Task<ResultDto<GenderDto>> GetById(int id)
        {
            var result = new ResultDto<GenderDto>();
            try
            {
                var entity = await _genderRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<GenderDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<GenderDto>> CreateOrEdit(GenderDto input)
        {
            if (Check.IsNullOrDefault(input.Id))
                return await Create(input);
            else
                return await Update(input);
        }

        public virtual async Task<ResultDto<GenderDto>> Create(GenderDto input)
        {
            var result = new ResultDto<GenderDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = ObjectMapper.Map<Gender>(input);
                    await _genderRepository.InsertAsync(entity);

                    unitOfWork.Complete();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<GenderDto>> Update(GenderDto input)
        {
            var result = new ResultDto<GenderDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _genderRepository.GetAsync(input.Id.GetValueOrDefault());

                    ObjectMapper.Map(input, entity);

                    unitOfWork.Complete();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<GenderDto>> Delete(int id)
        {
            var result = new ResultDto<GenderDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _genderRepository.Get(id);

                    await _genderRepository.DeleteAsync(entity);

                    unitOfWork.Complete();
                    result.Success(null);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

    }
}
