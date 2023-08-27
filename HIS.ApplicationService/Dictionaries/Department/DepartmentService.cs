using AutoMapper;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Department;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.Department
{
    public class DepartmentService : BaseSerivce, IDepartmentService
    {
        public DepartmentService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, config, mapper)
        {

        }

        public async Task<ApiResult<DepartmentDto>> CreateOrEdit(DepartmentDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<DepartmentDto>> Create(DepartmentDto input)
        {
            var result = new ApiResult<DepartmentDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = _mapper.Map<EntityFrameworkCore.Entities.Dictionaries.Department>(input);
                    _dbContext.Departments.Add(data);
                    await _dbContext.SaveChangesAsync();

                    result.IsSuccessed = true;
                    result.Result = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public async Task<ApiResult<DepartmentDto>> Update(DepartmentDto input)
        {
            var result = new ApiResult<DepartmentDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var data = _mapper.Map<EntityFrameworkCore.Entities.Dictionaries.Department>(input);
                    _dbContext.Departments.Update(data);
                    await _dbContext.SaveChangesAsync();

                    result.IsSuccessed = true;
                    result.Result = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public async Task<ApiResult<DepartmentDto>> Delete(Guid id)
        {
            var result = new ApiResult<DepartmentDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var department = _dbContext.Departments.SingleOrDefault(x => x.Id == id);
                    if (department != null)
                    {
                        _dbContext.Departments.Remove(department);
                        await _dbContext.SaveChangesAsync();
                        result.IsSuccessed = true;

                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public async Task<ApiResultList<DepartmentDto>> GetAll(GetAllDepartmentInput input)
        {
            var result = new ApiResultList<DepartmentDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from d in _dbContext.Departments
                                 join b in _dbContext.Branchs on d.BranchId equals b.Id 
                                 where (string.IsNullOrEmpty(input.NameFilter) || d.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || d.Code == input.CodeFilter)
                                     && (input.BranchIdFilter == null || d.BranchId == input.BranchIdFilter)
                                     && (input.InactiveFilter == null || d.Inactive == input.InactiveFilter)
                                 select new DepartmentDto()
                                 {
                                     Id = d.Id,
                                     Code = d.Code,
                                     MohCode = d.MohCode,
                                     Name = d.Name,
                                     Description = d.Description,
                                     DepartmentTypeId = d.DepartmentTypeId,
                                     BranchId = d.BranchId,
                                     BranchCode = b.Code,
                                     BranchName = b.Name,
                                     Inactive = d.Inactive,
                                     SortOrder = d.SortOrder,
                                 }).ToList();
                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<DepartmentDto>> GetById(Guid id)
        {
            var result = new ApiResult<DepartmentDto>();
            var department = await (from d in _dbContext.Departments
                                    join b in _dbContext.Branchs on d.BranchId equals b.Id
                                    where d.Id == id
                                    select new DepartmentDto()
                                    {
                                        Id = d.Id,
                                        Code = d.Code,
                                        MohCode = d.MohCode,
                                        Name = d.Name,
                                        Description = d.Description,
                                        DepartmentTypeId = d.DepartmentTypeId,
                                        BranchId = d.BranchId,
                                        BranchCode = b.Code,
                                        BranchName = b.Name,
                                        Inactive = d.Inactive,
                                        SortOrder = d.SortOrder,
                                    }).SingleOrDefaultAsync();


            if (department != null)
            {
                result.IsSuccessed = true;
                result.Result = department;
            }

            return await Task.FromResult(result);
        }
    }
}
