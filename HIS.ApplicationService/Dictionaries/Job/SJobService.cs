using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Job;
using HIS.EntityFrameworkCore.DbContexts;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.Job
{
    public class SJobService : BaseSerivce, ISJobService
    {
        public SJobService(HIS_DbContext dbContext, IConfiguration config)
            : base(dbContext, config)
        {

        }

        public async Task<ApiResult<SJobDto>> CreateOrEdit(SJobDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<SJobDto>> Create(SJobDto input)
        {
            var result = new ApiResult<SJobDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var branch = new SJob()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Description = input.Description,
                        Inactive = input.Inactive
                    };
                    _dbContext.SJobs.Add(branch);
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

        public async Task<ApiResult<SJobDto>> Update(SJobDto input)
        {
            var result = new ApiResult<SJobDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var job = new SJob()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Description = input.Description,
                        Inactive = input.Inactive
                    };
                    _dbContext.SJobs.Update(job);
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

        public async Task<ApiResult<SJobDto>> Delete(Guid id)
        {
            var result = new ApiResult<SJobDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var job = _dbContext.SJobs.SingleOrDefault(x => x.Id == id);
                    if (job != null)
                    {
                        _dbContext.SJobs.Remove(job);
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

        public async Task<ApiResultList<SJobDto>> GetAll(GetAllSJobInput input)
        {
            var result = new ApiResultList<SJobDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.SJobs
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new SJobDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Description = r.Description,
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

        public async Task<ApiResult<SJobDto>> GetById(Guid id)
        {
            var result = new ApiResult<SJobDto>();

            var branch = _dbContext.SJobs.SingleOrDefault(s => s.Id == id);
            if (branch != null)
            {
                result.IsSuccessed = true;
                result.Result = new SJobDto()
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
