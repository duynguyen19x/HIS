using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Province;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.Province
{
    public class ProvinceService : BaseSerivce, IProvinceService
    {
        public ProvinceService(HISDbContext dbContext, IConfiguration config)
            : base(dbContext, config)
        {

        }

        public async Task<ApiResult<ProvinceDto>> CreateOrEdit(ProvinceDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<ProvinceDto>> Create(ProvinceDto input)
        {
            var result = new ApiResult<ProvinceDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var branch = new EntityFrameworkCore.Entities.Dictionaries.Province()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Inactive = input.Inactive
                    };
                    _dbContext.Provinces.Add(branch);
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

        public async Task<ApiResult<ProvinceDto>> Update(ProvinceDto input)
        {
            var result = new ApiResult<ProvinceDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var job = new EntityFrameworkCore.Entities.Dictionaries.Province()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Inactive = input.Inactive
                    };
                    _dbContext.Provinces.Update(job);
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

        public async Task<ApiResult<ProvinceDto>> Delete(Guid id)
        {
            var result = new ApiResult<ProvinceDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var job = _dbContext.Provinces.SingleOrDefault(x => x.Id == id);
                    if (job != null)
                    {
                        _dbContext.Provinces.Remove(job);
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

        public async Task<ApiResultList<ProvinceDto>> GetAll(GetAllProvinceInput input)
        {
            var result = new ApiResultList<ProvinceDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.Provinces
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new ProvinceDto()
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

        public async Task<ApiResult<ProvinceDto>> GetById(Guid id)
        {
            var result = new ApiResult<ProvinceDto>();

            var branch = _dbContext.Provinces.SingleOrDefault(s => s.Id == id);
            if (branch != null)
            {
                result.IsSuccessed = true;
                result.Result = new ProvinceDto()
                {
                    Id = branch.Id,
                    Code = branch.Code,
                    Name = branch.Name,
                    Inactive = branch.Inactive
                };
            }

            return await Task.FromResult(result);
        }
    }
}
