using HIS.ApplicationService.Dictionaries.Country;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Country;
using HIS.Dtos.Dictionaries.Ward;
using HIS.EntityFrameworkCore.DbContexts;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.Ward
{
    public class SWardService : BaseSerivce, ISWardService
    {
        public SWardService(HIS_DbContext dbContext, IConfiguration config)
            : base(dbContext, config)
        {

        }

        public async Task<ApiResult<SWardDto>> CreateOrEdit(SWardDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<SWardDto>> Create(SWardDto input)
        {
            var result = new ApiResult<SWardDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var branch = new SWard()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Description = input.Description,
                        Inactive = input.Inactive
                    };
                    _dbContext.SWards.Add(branch);
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

        public async Task<ApiResult<SWardDto>> Update(SWardDto input)
        {
            var result = new ApiResult<SWardDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var job = new SWard()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Description = input.Description,
                        Inactive = input.Inactive
                    };
                    _dbContext.SWards.Update(job);
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

        public async Task<ApiResult<SWardDto>> Delete(Guid id)
        {
            var result = new ApiResult<SWardDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var job = _dbContext.SWards.SingleOrDefault(x => x.Id == id);
                    if (job != null)
                    {
                        _dbContext.SWards.Remove(job);
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

        public async Task<ApiResultList<SWardDto>> GetAll(GetAllSWardInput input)
        {
            var result = new ApiResultList<SWardDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.SWards
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new SWardDto()
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

        public async Task<ApiResult<SWardDto>> GetById(Guid id)
        {
            var result = new ApiResult<SWardDto>();

            var branch = _dbContext.SWards.SingleOrDefault(s => s.Id == id);
            if (branch != null)
            {
                result.IsSuccessed = true;
                result.Result = new SWardDto()
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
