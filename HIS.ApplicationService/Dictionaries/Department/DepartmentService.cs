﻿using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Dictionaries.Department;
using HIS.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.Department
{
    public class DepartmentService : BaseCrudAppService<DepartmentDto, Guid?, GetAllDepartmentInput>, IDepartmentService
    {
        public DepartmentService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, mapper)
        {

        }

        public override async Task<ResultDto<DepartmentDto>> Create(DepartmentDto input)
        {
            var result = new ResultDto<DepartmentDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = ObjectMapper.Map<EntityFrameworkCore.Entities.Dictionaries.Department>(input);
                    Context.Departments.Add(data);
                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Item = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<DepartmentDto>> Update(DepartmentDto input)
        {
            var result = new ResultDto<DepartmentDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var data = ObjectMapper.Map<EntityFrameworkCore.Entities.Dictionaries.Department>(input);
                    Context.Departments.Update(data);
                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Item = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<DepartmentDto>> Delete(Guid? id)
        {
            var result = new ResultDto<DepartmentDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var department = Context.Departments.SingleOrDefault(x => x.Id == id);
                    if (department != null)
                    {
                        Context.Departments.Remove(department);
                        await Context.SaveChangesAsync();
                        result.IsSucceeded = true;

                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public override async Task<PagedResultDto<DepartmentDto>> GetAll(GetAllDepartmentInput input)
        {
            var result = new PagedResultDto<DepartmentDto>();
            try
            {
                result.IsSucceeded = true;
                result.Items = (from d in Context.Departments
                                 join b in Context.Branchs on d.BranchId equals b.Id 
                                 where (string.IsNullOrEmpty(input.DepartmentNameFilter) || d.DepartmentName == input.DepartmentNameFilter)
                                     && (string.IsNullOrEmpty(input.DepartmentCodeFilter) || d.DepartmentCode == input.DepartmentCodeFilter)
                                     && (input.BranchFilter == null || d.BranchId == input.BranchFilter)
                                     && (input.InactiveFilter == null || d.Inactive == input.InactiveFilter)
                                 select new DepartmentDto()
                                 {
                                     Id = d.Id,
                                     DepartmentCode = d.DepartmentCode,
                                     DepartmentName = d.DepartmentName,
                                     MohCode = d.MohCode,
                                     Description = d.Description,
                                     DepartmentTypeId = d.DepartmentTypeId,
                                     BranchId = d.BranchId,
                                     BranchCode = b.BranchCode,
                                     BranchName = b.BranchName,
                                     Inactive = d.Inactive,
                                     SortOrder = d.SortOrder,
                                 }).ToList();
                result.TotalCount = result.Items.Count;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<DepartmentDto>> GetById(Guid? id)
        {
            var result = new ResultDto<DepartmentDto>();
            var department = await (from d in Context.Departments
                                    join b in Context.Branchs on d.BranchId equals b.Id
                                    where d.Id == id
                                    select new DepartmentDto()
                                    {
                                        Id = d.Id,
                                        DepartmentCode = d.DepartmentCode,
                                        DepartmentName = d.DepartmentName,
                                        MohCode = d.MohCode,
                                        Description = d.Description,
                                        DepartmentTypeId = d.DepartmentTypeId,
                                        BranchId = d.BranchId,
                                        BranchCode = b.BranchCode,
                                        BranchName = b.BranchName,
                                        Inactive = d.Inactive,
                                        SortOrder = d.SortOrder,
                                    }).SingleOrDefaultAsync();


            if (department != null)
            {
                result.IsSucceeded = true;
                result.Item = department;
            }

            return await Task.FromResult(result);
        }
    }
}
