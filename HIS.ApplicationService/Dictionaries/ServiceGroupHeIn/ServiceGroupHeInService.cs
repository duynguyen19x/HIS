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

        public async Task<ApiResult<ServiceGroupHeInDto>> CreateOrEdit(ServiceGroupHeInDto input)
        {
            if (GuidHelper.IsNullOrEmpty(input.Id))
                return await Create(input);
            else
                return await Update(input);
        }

        private async Task<ApiResult<ServiceGroupHeInDto>> Create(ServiceGroupHeInDto input)
        {
            var result = new ApiResult<ServiceGroupHeInDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();

                    var data = _mapper.Map<EntityFrameworkCore.Entities.Categories.Services.ServiceGroupHeIn>(input);

                    _dbContext.ServiceGroupHeIns.Add(data);
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

        private async Task<ApiResult<ServiceGroupHeInDto>> Update(ServiceGroupHeInDto input)
        {
            var result = new ApiResult<ServiceGroupHeInDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var sServiceGroupHeIn = _dbContext.ServiceGroupHeIns.FirstOrDefault(f => f.Id == input.Id);
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

        public async Task<ApiResult<ServiceGroupHeInDto>> Delete(Guid id)
        {
            var result = new ApiResult<ServiceGroupHeInDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var sServiceGroupHeIn = _dbContext.ServiceGroupHeIns.SingleOrDefault(x => x.Id == id);
                    if (sServiceGroupHeIn != null)
                    {
                        _dbContext.ServiceGroupHeIns.Remove(sServiceGroupHeIn);
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

        public async Task<ApiResultList<ServiceGroupHeInDto>> GetAll(GetAllServiceGroupHeInInput input)
        {
            var result = new ApiResultList<ServiceGroupHeInDto>();

            try
            {
                result.Result = (from r in _dbContext.ServiceGroupHeIns
                                 select new ServiceGroupHeInDto()
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

        public async Task<ApiResult<ServiceGroupHeInDto>> GetById(Guid id)
        {
            var result = new ApiResult<ServiceGroupHeInDto>();

            try
            {
                var service = _dbContext.ServiceGroupHeIns.FirstOrDefault(s => s.Id == id);
                result.Result = _mapper.Map<ServiceGroupHeInDto>(service);
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
