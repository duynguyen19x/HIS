using AutoMapper;
using HIS.ApplicationService.Dictionaries.Branch;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Branch;
using HIS.Dtos.Dictionaries.Department;
using HIS.EntityFrameworkCore.DbContexts;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Models.Commons;
using Microsoft.EntityFrameworkCore;
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
        public SDepartmentService(HIS_DbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, config, mapper)
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
                    var data = _mapper.Map<SDepartment>(input);
                    _dbContext.SDepartments.Add(data);
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
                    var data = _mapper.Map<SDepartment>(input);
                    _dbContext.SDepartments.Update(data);
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
                result.Result = (from d in _dbContext.SDepartments
                                 join b in _dbContext.SBranchs on d.BranchId equals b.Id 
                                 where (string.IsNullOrEmpty(input.NameFilter) || d.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || d.Code == input.CodeFilter)
                                     && (input.BranchIdFilter == null || d.BranchId == input.BranchIdFilter)
                                     && (input.InactiveFilter == null || d.Inactive == input.InactiveFilter)
                                 select new SDepartmentDto()
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

        public async Task<ApiResult<SDepartmentDto>> GetById(Guid id)
        {
            var result = new ApiResult<SDepartmentDto>();
            var department = await (from d in _dbContext.SDepartments
                                    join b in _dbContext.SBranchs on d.BranchId equals b.Id
                                    where d.Id == id
                                    select new SDepartmentDto()
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
