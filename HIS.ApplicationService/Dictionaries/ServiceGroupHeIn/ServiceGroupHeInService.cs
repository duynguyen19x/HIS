using HIS.Core.Linq;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ServiceGroupHeIn;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.ServiceGroupHeIn
{
    public class ServiceGroupHeInService : BaseSerivce, IServiceGroupHeInService
    {
        public ServiceGroupHeInService(HISDbContext dbContext, IConfiguration config) : base(dbContext, config)
        {
        }

        public async Task<ApiResult<SServiceGroupHeInDto>> CreateOrEdit(SServiceGroupHeInDto input)
        {
            if (GuidHelper.IsNullOrEmpty(input.Id))
                return await Create(input);
            else
                return await Update(input);
        }

        private async Task<ApiResult<SServiceGroupHeInDto>> Create(SServiceGroupHeInDto input)
        {
            var result = new ApiResult<SServiceGroupHeInDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();

                    var data = _mapper.Map<EntityFrameworkCore.Entities.Categories.Services.ServiceGroupHeIn>(input);

                    _dbContext.SServiceGroupHeIns.Add(data);
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

        private async Task<ApiResult<SServiceGroupHeInDto>> Update(SServiceGroupHeInDto input)
        {
            var result = new ApiResult<SServiceGroupHeInDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var sServiceGroupHeIn = _dbContext.SServiceGroupHeIns.FirstOrDefault(f => f.Id == input.Id);
                    if (sServiceGroupHeIn == null)
                        _mapper.Map(input, sServiceGroupHeIn);

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

        public async Task<ApiResult<SServiceGroupHeInDto>> Delete(Guid id)
        {
            var result = new ApiResult<SServiceGroupHeInDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var sServiceGroupHeIn = _dbContext.SServiceGroupHeIns.SingleOrDefault(x => x.Id == id);
                    if (sServiceGroupHeIn != null)
                    {
                        _dbContext.SServiceGroupHeIns.Remove(sServiceGroupHeIn);
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

        public async Task<ApiResultList<SServiceGroupHeInDto>> GetAll(GetAllSServiceGroupHeInInput input)
        {
            var result = new ApiResultList<SServiceGroupHeInDto>();

            try
            {
                result.Result = (from r in _dbContext.SServiceGroupHeIns
                                 select new SServiceGroupHeInDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Inactive = r.Inactive,
                                     SortOrder = r.SortOrder,
                                 })
                                 .WhereIf(input.InactiveFilter != null, w => w.Inactive == input.InactiveFilter)
                                 .OrderBy(o => o.SortOrder).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<SServiceGroupHeInDto>> GetById(Guid id)
        {
            var result = new ApiResult<SServiceGroupHeInDto>();

            try
            {
                var service = _dbContext.SServiceGroupHeIns.FirstOrDefault(s => s.Id == id);
                result.Result = _mapper.Map<SServiceGroupHeInDto>(service);
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }
    }
}
