using AutoMapper;
using HIS.ApplicationService.Dictionaries.Country;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Country;
using HIS.Dtos.Dictionaries.District;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.District
{
    public class SDistrictService : BaseSerivce, ISDistrictService
    {
        public SDistrictService(HISDbContext dbContext, IConfiguration config)
            : base(dbContext, config)
        {

        }

        public async Task<ApiResult<SDistrictDto>> CreateOrEdit(SDistrictDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<SDistrictDto>> Create(SDistrictDto input)
        {
            var result = new ApiResult<SDistrictDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = new EntityFrameworkCore.Entities.Dictionaries.District()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Description = input.Description,
                        Inactive = input.Inactive
                    };
                    _dbContext.SDistricts.Add(data);
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

        public async Task<ApiResult<SDistrictDto>> Update(SDistrictDto input)
        {
            var result = new ApiResult<SDistrictDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var job = new EntityFrameworkCore.Entities.Dictionaries.District()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Description = input.Description,
                        Inactive = input.Inactive
                    };
                    _dbContext.SDistricts.Update(job);
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

        public async Task<ApiResult<SDistrictDto>> Delete(Guid id)
        {
            var result = new ApiResult<SDistrictDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var job = _dbContext.SDistricts.SingleOrDefault(x => x.Id == id);
                    if (job != null)
                    {
                        _dbContext.SDistricts.Remove(job);
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

        public async Task<ApiResultList<SDistrictDto>> GetAll(GetAllSDistrictInput input)
        {
            var result = new ApiResultList<SDistrictDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.SDistricts
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new SDistrictDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Description = r.Description,
                                     Inactive = r.Inactive
                                 }).OrderBy(o => o.Code).ToList();
                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<SDistrictDto>> GetById(Guid id)
        {
            var result = new ApiResult<SDistrictDto>();

            var branch = _dbContext.SDistricts.SingleOrDefault(s => s.Id == id);
            if (branch != null)
            {
                result.IsSuccessed = true;
                result.Result = new SDistrictDto()
                {
                    Id = branch.Id,
                    Code = branch.Code,
                    Name = branch.Name,
                    Description = branch.Description,
                    Inactive = branch.Inactive
                };
            }

            return await Task.FromResult(result);
        }
    }
}
