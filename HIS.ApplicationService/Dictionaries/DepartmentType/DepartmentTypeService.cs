﻿using AutoMapper;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.DepartmentType;
using HIS.Dtos.Dictionaries.RoomType;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.DepartmentType
{
    public class DepartmentTypeService : BaseSerivce, IDepartmentTypeService
    {
        public DepartmentTypeService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, config, mapper)
        {

        }

        public async Task<ApiResult<DepartmentTypeDto>> CreateOrEdit(DepartmentTypeDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<DepartmentTypeDto>> Create(DepartmentTypeDto input)
        {
            var result = new ApiResult<DepartmentTypeDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    //input.Id = Guid.NewGuid();
                    var data = _mapper.Map<EntityFrameworkCore.Entities.Dictionaries.DepartmentType>(input);
                    _dbContext.DepartmentTypes.Add(data);
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

        public async Task<ApiResult<DepartmentTypeDto>> Update(DepartmentTypeDto input)
        {
            var result = new ApiResult<DepartmentTypeDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var data = _mapper.Map<EntityFrameworkCore.Entities.Dictionaries.DepartmentType>(input);
                    _dbContext.DepartmentTypes.Update(data);
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

        public async Task<ApiResult<DepartmentTypeDto>> Delete(int id)
        {
            var result = new ApiResult<DepartmentTypeDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var data = _dbContext.DepartmentTypes.SingleOrDefault(x => x.Id == id);
                    if (data != null)
                    {
                        _dbContext.DepartmentTypes.Remove(data);
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

        public async Task<ApiResultList<DepartmentTypeDto>> GetAll(GetAllDepartmentTypeInput input)
        {
            var result = new ApiResultList<DepartmentTypeDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.DepartmentTypes
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new DepartmentTypeDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Description = r.Description,
                                     SortOrder = r.SortOrder,
                                     Inactive = r.Inactive
                                 })
                                 .OrderBy(o => o.SortOrder)
                                 .ThenBy(o => o.Code)
                                 .ToList();
                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<DepartmentTypeDto>> GetById(int id)
        {
            var result = new ApiResult<DepartmentTypeDto>();
            var data = _dbContext.DepartmentTypes.SingleOrDefault(s => s.Id == id);
            if (data != null)
            {
                result.IsSuccessed = true;
                result.Result = new DepartmentTypeDto()
                {
                    Id = data.Id,
                    Code = data.Code,
                    Name = data.Name,
                    Description = data.Description,
                    SortOrder = data.SortOrder,
                    Inactive = data.Inactive
                };
            }

            return await Task.FromResult(result);
        }
    }
}
