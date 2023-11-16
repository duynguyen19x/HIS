using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Country;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;
using AutoMapper;
using HIS.EntityFrameworkCore;

namespace HIS.ApplicationService.Dictionaries.Country
{
    public class CountryService : BaseSerivce, ICountryService
    {
        public CountryService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, config, mapper)
        {

        }

        public async Task<ApiResult<CountryDto>> CreateOrEdit(CountryDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<CountryDto>> Create(CountryDto input)
        {
            var result = new ApiResult<CountryDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = _mapper.Map<EntityFrameworkCore.Entities.Dictionaries.Country>(input); 
                    _dbContext.Countries.Add(data);
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

        public async Task<ApiResult<CountryDto>> Update(CountryDto input)
        {
            var result = new ApiResult<CountryDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var data = _mapper.Map<EntityFrameworkCore.Entities.Dictionaries.Country>(input);
                    _dbContext.Countries.Update(data);
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

        public async Task<ApiResult<CountryDto>> Delete(Guid id)
        {
            var result = new ApiResult<CountryDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var job = _dbContext.Countries.SingleOrDefault(x => x.Id == id);
                    if (job != null)
                    {
                        _dbContext.Countries.Remove(job);
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

        public async Task<ApiResultList<CountryDto>> GetAll(GetAllCountryInput input)
        {
            var result = new ApiResultList<CountryDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.Countries
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new CountryDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
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

        public async Task<ApiResult<CountryDto>> GetById(Guid id)
        {
            var result = new ApiResult<CountryDto>();

            var data = _dbContext.Countries.SingleOrDefault(s => s.Id == id);
            if (data != null)
            {
                result.IsSuccessed = true;
                result.Result = _mapper.Map<CountryDto>(data);
            }

            return await Task.FromResult(result);
        }
    }
}
