using AutoMapper;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.DepartmentType;
using HIS.Dtos.Dictionaries.RoomType;
using HIS.EntityFrameworkCore.DbContexts;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
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
    public class SDepartmentTypeService : BaseSerivce, ISDepartmentTypeService
    {
        public SDepartmentTypeService(HIS_DbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, config, mapper)
        {

        }

        public async Task<ApiResult<SDepartmentTypeDto>> CreateOrEdit(SDepartmentTypeDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<SDepartmentTypeDto>> Create(SDepartmentTypeDto input)
        {
            var result = new ApiResult<SDepartmentTypeDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = _mapper.Map<SDepartmentType>(input);
                    _dbContext.SDepartmentTypes.Add(data);
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

        public async Task<ApiResult<SDepartmentTypeDto>> Update(SDepartmentTypeDto input)
        {
            var result = new ApiResult<SDepartmentTypeDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var data = _mapper.Map<SDepartmentType>(input);
                    _dbContext.SDepartmentTypes.Update(data);
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

        public async Task<ApiResult<SDepartmentTypeDto>> Delete(Guid id)
        {
            var result = new ApiResult<SDepartmentTypeDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var data = _dbContext.SDepartmentTypes.SingleOrDefault(x => x.Id == id);
                    if (data != null)
                    {
                        _dbContext.SDepartmentTypes.Remove(data);
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

        public async Task<ApiResultList<SDepartmentTypeDto>> GetAll(GetAllSDepartmentTypeInput input)
        {
            var result = new ApiResultList<SDepartmentTypeDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.SDepartmentTypes
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new SDepartmentTypeDto()
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

        public async Task<ApiResult<SDepartmentTypeDto>> GetById(Guid id)
        {
            var result = new ApiResult<SDepartmentTypeDto>();
            var data = _dbContext.SDepartmentTypes.SingleOrDefault(s => s.Id == id);
            if (data != null)
            {
                result.IsSuccessed = true;
                result.Result = new SDepartmentTypeDto()
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
