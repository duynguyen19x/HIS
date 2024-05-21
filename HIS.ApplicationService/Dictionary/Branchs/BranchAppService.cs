using HIS.Core.Domain.Repositories;
using HIS.Dtos.Dictionaries.Branchs;
using Microsoft.EntityFrameworkCore;
using System.Transactions;
using HIS.Core.Extensions;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.EntityFrameworkCore.Entities;
using HIS.ApplicationService.Dictionary.Branchs.Dto;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace HIS.ApplicationService.Dictionary.Branchs
{
    public class BranchAppService : BaseAppService, IBranchAppService
    {
        private readonly IRepository<Branch, Guid> _branchRepository;

        public BranchAppService(
            IRepository<Branch, Guid> branchRepository) 
        {
            _branchRepository = branchRepository;
        }

        public virtual async Task<PagedResultDto<BranchDto>> GetAllAsync(GetAllBranchInputDto input)
        {
            var result = new PagedResultDto<BranchDto>();
            try
            {
                var query = _branchRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code == input.CodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name == input.NameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);
                var paged = query.ApplySortingAndPaging(input);

                result.TotalCount = await query.CountAsync();
                result.Result = ObjectMapper.Map<IList<BranchDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<BranchDto>> GetAsync(Guid id)
        {
            var result = new ResultDto<BranchDto>();
            try
            {
                var entity = await _branchRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<BranchDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<BranchDto>> CreateOrUpdateAsync(BranchDto input)
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

        public virtual async Task<ResultDto<BranchDto>> CreateAsync(BranchDto input)
        {
            var result = new ResultDto<BranchDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var branch = ObjectMapper.Map<Branch>(input);

                    await _branchRepository.InsertAsync(branch);

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

        public virtual async Task<ResultDto<BranchDto>> UpdateAsync(BranchDto input)
        {
            var result = new ResultDto<BranchDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _branchRepository.GetAsync(input.Id.GetValueOrDefault());

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

        public virtual async Task<ResultDto<BranchDto>> DeleteAsync(Guid id)
        {
            var result = new ResultDto<BranchDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var branch = _branchRepository.Get(id);

                    await _branchRepository.DeleteAsync(branch);

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
