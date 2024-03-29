﻿using HIS.Core.Domain.Repositories;
using HIS.Dtos.Dictionaries.Branchs;
using HIS.Core.Services;
using HIS.Core.Services.Dto;
using HIS.Dtos.Systems;
using HIS.Dtos.Systems.RefType;
using HIS.Dtos.Dictionaries.Branchs;
using HIS.Core.Linq.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Transactions;
using HIS.Utilities.Helpers;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;
using HIS.Core.Services;

namespace HIS.ApplicationService.Dictionaries.Branchs
{
    public class DIBranchAppService : BaseAppService, IDIBranchAppService
    {
        private readonly IRepository<Branch, Guid> _diBranchRepository;

        public DIBranchAppService(IRepository<Branch, Guid> diBranchRepository) 
        {
            _diBranchRepository = diBranchRepository;
        }

        public virtual async Task<PagedResultDto<DIBranchDto>> GetAllAsync(GetAllDIBranchInputDto input)
        {
            var result = new PagedResultDto<DIBranchDto>();
            try
            {
                var query = _diBranchRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.BranchCodeFilter), x => x.Code == input.BranchCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.BranchNameFilter), x => x.Name == input.BranchNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);
                var paged = query.ApplySortingAndPaging(input);

                result.TotalCount = await query.CountAsync();
                result.Result = ObjectMapper.Map<IList<DIBranchDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<DIBranchDto>> GetAsync(Guid id)
        {
            var result = new ResultDto<DIBranchDto>();
            try
            {
                var entity = await _diBranchRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<DIBranchDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<DIBranchDto>> CreateOrUpdateAsync(DIBranchDto input)
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

        public virtual async Task<ResultDto<DIBranchDto>> CreateAsync(DIBranchDto input)
        {
            var result = new ResultDto<DIBranchDto>();
            try
            {
                using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
                {
                    var entity = ObjectMapper.Map<Branch>(input);

                    await _diBranchRepository.InsertAsync(entity);
                    unitOfWork.Complete();

                    result.Result = ObjectMapper.Map<DIBranchDto>(entity);
                    result.IsSucceeded = true;
                }
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<DIBranchDto>> UpdateAsync(DIBranchDto input)
        {
            var result = new ResultDto<DIBranchDto>();
            try
            {
                using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
                {
                    var entity = await _diBranchRepository.GetAsync(input.Id.GetValueOrDefault());

                    ObjectMapper.Map(input, entity);
                    unitOfWork.Complete();

                    result.Result = ObjectMapper.Map<DIBranchDto>(entity);
                    result.IsSucceeded = true;
                }
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<DIBranchDto>> DeleteAsync(Guid id)
        {
            var result = new ResultDto<DIBranchDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin())
            {
                try
                {
                    var entity = _diBranchRepository.Get(id);
                    await _diBranchRepository.DeleteAsync(entity);

                    result.Result = ObjectMapper.Map<DIBranchDto>(entity);
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
