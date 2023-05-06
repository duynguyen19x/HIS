using HIS.ApplicationService.Dictionaries.Branch;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Branch;
using HIS.Dtos.Dictionaries.Department;
using HIS.EntityFrameworkCore.DbContexts;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Models.Commons;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.Department
{
    public class SDepartmentService : BaseSerivce, ISDepartmentService
    {
        public SDepartmentService(HIS_DbContext dbContext, IConfiguration config)
            : base(dbContext, config)
        {

        }

        public async Task<ApiResult<SDepartmentDto>> CreateOrEdit(SDepartmentDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<SDepartmentDto>> Create(SDepartmentDto input)
        {
            var result = new ApiResult<SDepartmentDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var department = new SDepartment()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Description = input.Description,
                        BranchId = input.BranchId,
                        Inactive = input.Inactive
                    };
                    _dbContext.SDepartments.Add(department);
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

        public async Task<ApiResult<SDepartmentDto>> Update(SDepartmentDto input)
        {
            var result = new ApiResult<SDepartmentDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var department = new SDepartment()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Description = input.Description,
                        BranchId = input.BranchId,
                        Inactive = input.Inactive
                    };
                    _dbContext.SDepartments.Update(department);
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

        public async Task<ApiResult<SDepartmentDto>> Delete(Guid id)
        {
            var result = new ApiResult<SDepartmentDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var department = _dbContext.SDepartments.SingleOrDefault(x => x.Id == id);
                    if (department != null)
                    {
                        _dbContext.SDepartments.Remove(department);
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

        public async Task<ApiResultList<SDepartmentDto>> GetAll(GetAllSDepartmentInput input)
        {
            var result = new ApiResultList<SDepartmentDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.SDepartments
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.BranchIdFilter == null || r.BranchId == input.BranchIdFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new SDepartmentDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Description = r.Description,
                                     BranchId = r.BranchId,
                                     Inactive = r.Inactive
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

        public async Task<ApiResult<SDepartmentDto>> GetById(Guid id)
        {
            var result = new ApiResult<SDepartmentDto>();
            var department = _dbContext.SDepartments.SingleOrDefault(s => s.Id == id);
            if (department != null)
            {
                result.IsSuccessed = true;
                result.Result = new SDepartmentDto()
                {
                    Id = department.Id,
                    Code = department.Code,
                    Name = department.Name,
                    Description = department.Description,
                    BranchId = department.BranchId,
                    Inactive = department.Inactive
                };
            }

            return await Task.FromResult(result);
        }
    }
}
