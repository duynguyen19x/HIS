using HIS.ApplicationService.Dictionary.Branchs.Dto;
using HIS.ApplicationService.Dictionary.Departments.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities.Dictionary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Transactions;

namespace HIS.ApplicationService.Dictionary.Departments
{
    public class DepartmentAppService : BaseAppService, IDepartmentAppService
    {
        private readonly IRepository<Department, Guid> _departmentRepository;
        private readonly IRepository<DepartmentType, int> _departmentTypeRepository;
        private readonly IRepository<Branch, Guid> _branchRepository;
        private readonly IRepository<Employee, Guid> _employeeRepository;

        public DepartmentAppService(
            IRepository<Department, Guid> departmentRepository,
            IRepository<DepartmentType, int> departmentTypeRepository,
            IRepository<Branch, Guid> branchRepository,
            IRepository<Employee, Guid> employeeRepository)
        {
            _departmentRepository = departmentRepository;
            _departmentTypeRepository = departmentTypeRepository;
            _branchRepository = branchRepository;
            _employeeRepository = employeeRepository;
        }

        public virtual async Task<PagedResultDto<DepartmentDto>> GetAllAsync(GetAllDepartmentInputDto input)
        {
            var result = new PagedResultDto<DepartmentDto>();
            try
            {
                var filter = _departmentRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code == input.CodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name == input.NameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter)
                    .WhereIf(input.BranchFilter != null, x => x.BranchId == input.BranchFilter);

                var query = from o in filter

                            join o1 in _departmentTypeRepository.GetAll() on o.DepartmentTypeId equals o1.Id 
                            into j1 from s1 in j1.DefaultIfEmpty()

                            join o2 in _branchRepository.GetAll() on o.BranchId equals o2.Id 
                            into j2 from s2 in j2.DefaultIfEmpty()

                            join o3 in _employeeRepository.GetAll() on o.BranchId equals o3.Id
                            into j3 from s3 in j3.DefaultIfEmpty()

                            select new DepartmentDto()
                            {
                                Id = o.Id,
                                Code = o.Code,
                                Name = o.Name,
                                MediCode = o.MediCode,
                                DepartmentTypeId = o.DepartmentTypeId,
                                DepartmentTypeCode = s1.Code,
                                DepartmentTypeName = s1.Name,
                                BranchId = o.BranchId,
                                BranchCode = s2.Code,
                                BranchName = s2.Name,
                                ChiefId = o.ChiefId,
                                ChiefName = s3.Name,
                                Email = o.Email,
                                Tel = o.Tel,
                                Description = o.Description,
                                Inactive = o.Inactive,
                                SortOrder = o.SortOrder
                            };

                var paged = query.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = paged.ToList();
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<DepartmentDto>> GetAsync(Guid id)
        {
            var result = new ResultDto<DepartmentDto>();
            try
            {
                var entity = await _departmentRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<DepartmentDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<DepartmentDto>> CreateOrUpdateAsync(DepartmentDto input)
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

        public virtual async Task<ResultDto<DepartmentDto>> CreateAsync(DepartmentDto input)
        {
            var result = new ResultDto<DepartmentDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var entity = ObjectMapper.Map<Department>(input);

                    await _departmentRepository.InsertAsync(entity);

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

        public virtual async Task<ResultDto<DepartmentDto>> UpdateAsync(DepartmentDto input)
        {
            var result = new ResultDto<DepartmentDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _departmentRepository.GetAsync(input.Id.GetValueOrDefault());

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

        public virtual async Task<ResultDto<DepartmentDto>> DeleteAsync(Guid id)
        {
            var result = new ResultDto<DepartmentDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _departmentRepository.Get(id);

                    await _departmentRepository.DeleteAsync(entity);

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
