using HIS.ApplicationService.Dictionaries.Job;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Country;
using HIS.Dtos.Dictionaries.Job;
using HIS.EntityFrameworkCore.DbContexts;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.Country
{
    public class SCountryService : BaseSerivce, ISCountryService
    {
        public SCountryService(HIS_DbContext dbContext, IConfiguration config)
            : base(dbContext, config)
        {

        }

        public async Task<ApiResult<SCountryDto>> CreateOrEdit(SCountryDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<SCountryDto>> Create(SCountryDto input)
        {
            var result = new ApiResult<SCountryDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var branch = new SCountry()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Description = input.Description,
                        Inactive = input.Inactive
                    };
                    _dbContext.SCountries.Add(branch);
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

        public async Task<ApiResult<SCountryDto>> Update(SCountryDto input)
        {
            var result = new ApiResult<SCountryDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var job = new SCountry()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Description = input.Description,
                        Inactive = input.Inactive
                    };
                    _dbContext.SCountries.Update(job);
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

        public async Task<ApiResult<SCountryDto>> Delete(Guid id)
        {
            var result = new ApiResult<SCountryDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var job = _dbContext.SCountries.SingleOrDefault(x => x.Id == id);
                    if (job != null)
                    {
                        _dbContext.SCountries.Remove(job);
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

        public async Task<ApiResultList<SCountryDto>> GetAll(GetAllSCountryInput input)
        {
            var result = new ApiResultList<SCountryDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.SCountries
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new SCountryDto()
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

        public async Task<ApiResult<SCountryDto>> GetById(Guid id)
        {
            var result = new ApiResult<SCountryDto>();

            var branch = _dbContext.SCountries.SingleOrDefault(s => s.Id == id);
            if (branch != null)
            {
                result.IsSuccessed = true;
                result.Result = new SCountryDto()
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
