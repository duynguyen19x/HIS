using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Ethnic;
using HIS.EntityFrameworkCore;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.Ethnic
{
    public class EthnicService : BaseSerivce, IEthnicService
    {
        public EthnicService(HISDbContext dbContext, IConfiguration config)
            : base(dbContext, config)
        {

        }

        public async Task<ApiResult<EthnicDto>> CreateOrEdit(EthnicDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<EthnicDto>> Create(EthnicDto input)
        {
            var result = new ApiResult<EthnicDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var branch = new EntityFrameworkCore.Entities.Dictionaries.Ethnicity()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Description = input.Description,
                        Inactive = input.Inactive
                    };
                    _dbContext.Ethnics.Add(branch);
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

        public async Task<ApiResult<EthnicDto>> Update(EthnicDto input)
        {
            var result = new ApiResult<EthnicDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var ethnic = new EntityFrameworkCore.Entities.Dictionaries.Ethnicity()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Description = input.Description,
                        Inactive = input.Inactive
                    };
                    _dbContext.Ethnics.Update(ethnic);
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

        public async Task<ApiResult<EthnicDto>> Delete(Guid id)
        {
            var result = new ApiResult<EthnicDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var ethnic = _dbContext.Ethnics.SingleOrDefault(x => x.Id == id);
                    if (ethnic != null)
                    {
                        _dbContext.Ethnics.Remove(ethnic);
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

        public async Task<ApiResultList<EthnicDto>> GetAll(GetAllEthnicInput input)
        {
            var result = new ApiResultList<EthnicDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.Ethnics
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new EthnicDto()
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

        public async Task<ApiResult<EthnicDto>> GetById(Guid id)
        {
            var result = new ApiResult<EthnicDto>();

            var ethnic = _dbContext.Ethnics.SingleOrDefault(s => s.Id == id);
            if (ethnic != null)
            {
                result.IsSuccessed = true;
                result.Result = new EthnicDto()
                {
                    Id = ethnic.Id,
                    Code = ethnic.Code,
                    Name = ethnic.Name,
                    Description = ethnic.Description,
                    Inactive = ethnic.Inactive
                };
            }

            return await Task.FromResult(result);
        }
    }
}
