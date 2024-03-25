using AutoMapper;
using HIS.EntityFrameworkCore;
using HIS.Dtos.Dictionaries.Countries;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;
using HIS.Dtos.Dictionaries.ChapterICD10;
using HIS.Core.Domain.Repositories;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Core.Application.Services;
using System.Transactions;
using Microsoft.EntityFrameworkCore;
using HIS.ApplicationService.Dictionary.DepartmentTypes.Dto;
using HIS.EntityFrameworkCore.Entities.Dictionary;
using HIS.EntityFrameworkCore.Migrations;

namespace HIS.ApplicationService.Dictionaries.Countries
{
    public class CountryAppService : BaseAppService, ICountryAppService
    {
        private readonly IRepository<Country, Guid> _countryRepository;

        public CountryAppService(IRepository<Country, Guid> countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public virtual async Task<PagedResultDto<CountryDto>> GetAll(GetAllCountryInputDto input)
        {
            var result = new PagedResultDto<CountryDto>();
            try
            {
                var filter = _countryRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code == input.CodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name == input.NameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<CountryDto>>(paged.ToList());
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<CountryDto>> GetById(Guid id)
        {
            var result = new ResultDto<CountryDto>();
            try
            {
                var entity = await _countryRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<CountryDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<CountryDto>> CreateOrEdit(CountryDto input)
        {
            if (Check.IsNullOrDefault(input.Id))
            {
                return await Create(input);
            }
            else
            {
                return await Update(input);
            }
        }

        public virtual async Task<ResultDto<CountryDto>> Create(CountryDto input)
        {
            var result = new ResultDto<CountryDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var entity = ObjectMapper.Map<Country>(input);

                    await _countryRepository.InsertAsync(entity);

                    await unitOfWork.CompleteAsync();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<CountryDto>> Update(CountryDto input)
        {
            var result = new ResultDto<CountryDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _countryRepository.GetAsync(input.Id.GetValueOrDefault());

                    ObjectMapper.Map(input, entity);

                    await unitOfWork.CompleteAsync();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<CountryDto>> Delete(Guid id)
        {
            var result = new ResultDto<CountryDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _countryRepository.Get(id);

                    await _countryRepository.DeleteAsync(entity);

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
