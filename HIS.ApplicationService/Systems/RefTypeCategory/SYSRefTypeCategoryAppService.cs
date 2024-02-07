using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.Core.Linq.Extensions;
using HIS.Dtos.Systems;
using HIS.Dtos.Systems.RefTypeCategory;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Systems;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HIS.ApplicationService.Systems.RefTypeCategory
{
    public class SYSRefTypeCategoryAppService : HIS.Core.Application.Services.BaseAppService, ISYSRefTypeCategoryAppService
    {
        private readonly IRepository<SYSRefTypeCategory, int> _sysRefTypeCategoryRepository;

        public SYSRefTypeCategoryAppService(IRepository<SYSRefTypeCategory, int> sysRefTypeCategoryRepository) 
        {
            _sysRefTypeCategoryRepository = sysRefTypeCategoryRepository;
        }

        public virtual async Task<PagedResultDto<SYSRefTypeCategoryDto>> GetAllAsync(GetAllSYSRefTypeCategoryInputDto input)
        {
            var result = new PagedResultDto<SYSRefTypeCategoryDto>();
            try
            {
                var query = _sysRefTypeCategoryRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.RefTypeCategoryNameFilter), x => x.Name == input.RefTypeCategoryNameFilter);
                var paged = query.ApplySortingAndPaging(input);

                result.TotalCount = await query.CountAsync();
                result.Result = ObjectMapper.Map<IList<SYSRefTypeCategoryDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<SYSRefTypeCategoryDto>> GetAsync(int id)
        {
            var result = new ResultDto<SYSRefTypeCategoryDto>();
            try
            {
                var entity = await _sysRefTypeCategoryRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<SYSRefTypeCategoryDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<SYSRefTypeCategoryDto>> CreateOrUpdateAsync(SYSRefTypeCategoryDto input)
        {
            if (Check.IsNullOrDefault(input.Id))
            {
                return await CreateAsync(input);
            }
            else
            {
                return await UpdateAsync(input);
            }
        }

        public virtual async Task<ResultDto<SYSRefTypeCategoryDto>> CreateAsync(SYSRefTypeCategoryDto input)
        {
            var result = new ResultDto<SYSRefTypeCategoryDto>();
            try
            {
                using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
                {
                    var entity = ObjectMapper.Map<SYSRefTypeCategory>(input);

                    await _sysRefTypeCategoryRepository.InsertAsync(entity);
                    unitOfWork.Complete();

                    result.Result = ObjectMapper.Map<SYSRefTypeCategoryDto>(entity);
                    result.IsSucceeded = true;
                }
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<SYSRefTypeCategoryDto>> UpdateAsync(SYSRefTypeCategoryDto input)
        {
            var result = new ResultDto<SYSRefTypeCategoryDto>();
            try
            {
                using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
                {
                    var entity = await _sysRefTypeCategoryRepository.GetAsync(input.Id.GetValueOrDefault());

                    ObjectMapper.Map(input, entity);
                    unitOfWork.Complete();

                    result.Result = ObjectMapper.Map<SYSRefTypeCategoryDto>(entity);
                    result.IsSucceeded = true;
                }
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<SYSRefTypeCategoryDto>> DeleteAsync(int id)
        {
            var result = new ResultDto<SYSRefTypeCategoryDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin())
            {
                try
                {
                    var entity = _sysRefTypeCategoryRepository.Get(id);
                    await _sysRefTypeCategoryRepository.DeleteAsync(entity);

                    result.Result = ObjectMapper.Map<SYSRefTypeCategoryDto>(entity);
                    result.IsSucceeded = true;
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
