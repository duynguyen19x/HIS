using HIS.ApplicationService.Dictionary.DepartmentTypes.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace HIS.ApplicationService.Dictionary.DepartmentTypes
{
    public class DepartmentTypeAppService : BaseAppService, IDepartmentTypeAppService
    {
        private readonly IRepository<DepartmentType, int> _departmentTypeRepository;

        public DepartmentTypeAppService(IRepository<DepartmentType, int> departmentTypeRepository)
        {
            _departmentTypeRepository = departmentTypeRepository;
        }

        public virtual async Task<PagedResultDto<DepartmentTypeDto>> GetAllAsync(GetAllDepartmentTypeInputDto input)
        {
            var result = new PagedResultDto<DepartmentTypeDto>();
            try
            {
                var query = _departmentTypeRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code == input.CodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name == input.NameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);
                var paged = query.ApplySortingAndPaging(input);

                result.TotalCount = await query.CountAsync();
                result.Result = ObjectMapper.Map<IList<DepartmentTypeDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<DepartmentTypeDto>> GetAsync(int id)
        {
            var result = new ResultDto<DepartmentTypeDto>();
            try
            {
                var entity = await _departmentTypeRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<DepartmentTypeDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<DepartmentTypeDto>> CreateOrUpdateAsync(DepartmentTypeDto input)
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

        public virtual async Task<ResultDto<DepartmentTypeDto>> CreateAsync(DepartmentTypeDto input)
        {
            var result = new ResultDto<DepartmentTypeDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    //input.Id = Guid.NewGuid();
                    input.Id = _departmentTypeRepository.GetAll().DefaultIfEmpty().Max(x => x.Id) + 1;
                    var departmentType = ObjectMapper.Map<DepartmentType>(input);

                    await _departmentTypeRepository.InsertAsync(departmentType);

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

        public virtual async Task<ResultDto<DepartmentTypeDto>> UpdateAsync(DepartmentTypeDto input)
        {
            var result = new ResultDto<DepartmentTypeDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _departmentTypeRepository.GetAsync(input.Id.GetValueOrDefault());

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

        public virtual async Task<ResultDto<DepartmentTypeDto>> DeleteAsync(int id)
        {
            var result = new ResultDto<DepartmentTypeDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _departmentTypeRepository.Get(id);

                    await _departmentTypeRepository.DeleteAsync(entity);

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
