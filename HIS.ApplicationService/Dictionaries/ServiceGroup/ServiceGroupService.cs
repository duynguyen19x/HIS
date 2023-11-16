using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ServiceGroup;
using HIS.EntityFrameworkCore;
using HIS.Models.Commons;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.ServiceGroup
{
    public class ServiceGroupService : BaseSerivce, IServiceGroupService
    {
        public ServiceGroupService(HISDbContext dbContext, IConfiguration config, IMapper mapper) : base(dbContext, config, mapper)
        {
        }

        public async Task<ApiResult<ServiceGroupDto>> CreateOrEdit(ServiceGroupDto input)
        {
            if (GuidHelper.IsNullOrEmpty(input.Id))
                return await Create(input);
            else
                return await Update(input);
        }

        private async Task<ApiResult<ServiceGroupDto>> Create(ServiceGroupDto input)
        {
            var result = new ApiResult<ServiceGroupDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();

                    var data = _mapper.Map<EntityFrameworkCore.Entities.Categories.ServiceGroup>(input);

                    _dbContext.ServiceGroups.Add(data);
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

        private async Task<ApiResult<ServiceGroupDto>> Update(ServiceGroupDto input)
        {
            var result = new ApiResult<ServiceGroupDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var sServiceGroup = _dbContext.ServiceGroups.FirstOrDefault(f => f.Id == input.Id);
                    if (sServiceGroup == null)
                        _mapper.Map(input, sServiceGroup);

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

        public async Task<ApiResult<ServiceGroupDto>> Delete(Guid id)
        {
            var result = new ApiResult<ServiceGroupDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var serviceGroup = _dbContext.ServiceGroups.SingleOrDefault(x => x.Id == id);
                    if (serviceGroup != null)
                    {
                        _dbContext.ServiceGroups.Remove(serviceGroup);
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

        public async Task<ApiResultList<ServiceGroupDto>> GetAll(GetAllServiceGroupInput input)
        {
            var result = new ApiResultList<ServiceGroupDto>();

            try
            {
                result.Result = (from r in _dbContext.ServiceGroups
                                 select new ServiceGroupDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Inactive = r.Inactive,
                                     SortOrder = r.SortOrder,
                                 })
                                 .WhereIf(input.InactiveFilter != null, r => r.Inactive == input.InactiveFilter)
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

        public async Task<ApiResult<ServiceGroupDto>> GetById(Guid id)
        {
            var result = new ApiResult<ServiceGroupDto>();

            try
            {
                var service = _dbContext.ServiceGroups.FirstOrDefault(s => s.Id == id);
                result.Result = _mapper.Map<ServiceGroupDto>(service);
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
