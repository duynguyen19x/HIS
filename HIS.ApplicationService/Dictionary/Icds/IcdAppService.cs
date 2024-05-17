using HIS.Core.Application.Services.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Domain.Repositories;
using HIS.EntityFrameworkCore.Entities;
using HIS.ApplicationService.Dictionary.Icds.Dto;
using HIS.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace HIS.ApplicationService.Dictionary.Icds
{
    public class IcdAppService : BaseAppService, IIcdAppService
    {
        private readonly IRepository<Icd, Guid> _icdRepository;

        public IcdAppService(IRepository<Icd, Guid> icdRepository)
        {
            _icdRepository = icdRepository;
        }

        public virtual async Task<PagedResultDto<IcdDto>> GetAll(GetAllIcdInput input)
        {
            var result = new PagedResultDto<IcdDto>();
            try
            {
                var filter = _icdRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code == input.CodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name == input.NameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<IcdDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return result;
        }

        public virtual async Task<ResultDto<IcdDto>> GetById(Guid id)
        {
            var result = new ResultDto<IcdDto>();
            try
            {
                var entity = await _icdRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<IcdDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<IcdDto>> CreateOrEdit(IcdDto input)
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

        public virtual async Task<ResultDto<IcdDto>> Create(IcdDto input)
        {
            var result = new ResultDto<IcdDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var entity = ObjectMapper.Map<Icd>(input);

                    await _icdRepository.InsertAsync(entity);

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

        public virtual async Task<ResultDto<IcdDto>> Update(IcdDto input)
        {
            var result = new ResultDto<IcdDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _icdRepository.GetAsync(input.Id.GetValueOrDefault());

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

        public virtual async Task<ResultDto<IcdDto>> Delete(Guid id)
        {
            var result = new ResultDto<IcdDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _icdRepository.Get(id);

                    await _icdRepository.DeleteAsync(entity);

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
