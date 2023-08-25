using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Ethnic;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.Ethnic
{
    public class SEthnicService : BaseSerivce, ISEthnicService
    {
        public SEthnicService(HISDbContext dbContext, IConfiguration config)
            : base(dbContext, config)
        {

        }

        public async Task<ApiResult<SEthnicDto>> CreateOrEdit(SEthnicDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<SEthnicDto>> Create(SEthnicDto input)
        {
            var result = new ApiResult<SEthnicDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var branch = new EntityFrameworkCore.Entities.Dictionaries.Ethnic()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Description = input.Description,
                        Inactive = input.Inactive
                    };
                    _dbContext.SEthnics.Add(branch);
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

        public async Task<ApiResult<SEthnicDto>> Update(SEthnicDto input)
        {
            var result = new ApiResult<SEthnicDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var ethnic = new EntityFrameworkCore.Entities.Dictionaries.Ethnic()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Description = input.Description,
                        Inactive = input.Inactive
                    };
                    _dbContext.SEthnics.Update(ethnic);
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

        public async Task<ApiResult<SEthnicDto>> Delete(Guid id)
        {
            var result = new ApiResult<SEthnicDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var ethnic = _dbContext.SEthnics.SingleOrDefault(x => x.Id == id);
                    if (ethnic != null)
                    {
                        _dbContext.SEthnics.Remove(ethnic);
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

        public async Task<ApiResultList<SEthnicDto>> GetAll(GetAllSEthnicInput input)
        {
            var result = new ApiResultList<SEthnicDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.SEthnics
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new SEthnicDto()
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

        public async Task<ApiResult<SEthnicDto>> GetById(Guid id)
        {
            var result = new ApiResult<SEthnicDto>();

            var ethnic = _dbContext.SEthnics.SingleOrDefault(s => s.Id == id);
            if (ethnic != null)
            {
                result.IsSuccessed = true;
                result.Result = new SEthnicDto()
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
