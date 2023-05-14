using AutoMapper;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Career;
using HIS.EntityFrameworkCore.DbContexts;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.Career
{
    public class SCareerService : BaseSerivce, ISCareerService
    {
        public SCareerService(HIS_DbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, config, mapper)
        {
        }

        public async Task<ApiResult<SCareerDto>> CreateOrEdit(SCareerDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<SCareerDto>> Create(SCareerDto input)
        {
            var result = new ApiResult<SCareerDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = _mapper.Map<SCareer>(input);
                    _dbContext.SCareers.Add(data);
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

        public async Task<ApiResult<SCareerDto>> Update(SCareerDto input)
        {
            var result = new ApiResult<SCareerDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var data = _mapper.Map<SCareer>(input);
                    _dbContext.SCareers.Update(data);
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

        public async Task<ApiResult<SCareerDto>> Delete(Guid id)
        {
            var result = new ApiResult<SCareerDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var data = _dbContext.SCareers.SingleOrDefault(x => x.Id == id);
                    if (data != null)
                    {
                        _dbContext.SCareers.Remove(data);
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

        public async Task<ApiResultList<SCareerDto>> GetAll(GetAllSCareerInput input)
        {
            var result = new ApiResultList<SCareerDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.SCareers
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new SCareerDto()
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

        public async Task<ApiResult<SCareerDto>> GetById(Guid id)
        {
            var result = new ApiResult<SCareerDto>();

            var data = _dbContext.SCareers.SingleOrDefault(s => s.Id == id);
            if (data != null)
            {
                result.IsSuccessed = true;
                result.Result = _mapper.Map<SCareerDto>(data);
            }

            return await Task.FromResult(result);
        }
    }
}
