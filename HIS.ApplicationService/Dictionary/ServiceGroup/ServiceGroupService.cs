using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.ServiceGroup;
using HIS.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;

namespace HIS.ApplicationService.Dictionaries.ServiceGroup
{
    public class ServiceGroupService : BaseCrudAppService<ServiceGroupDto, Guid, GetAllServiceGroupInput>, IServiceGroupService
    {
        public ServiceGroupService(HISDbContext dbContext, IConfiguration config, IMapper mapper) 
            : base(dbContext, mapper)
        {
        }

        public override async Task<ResultDto<ServiceGroupDto>> Create(ServiceGroupDto input)
        {
            var result = new ResultDto<ServiceGroupDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();

                    var data = ObjectMapper.Map<EntityFrameworkCore.Entities.Categories.ServiceGroup>(input);

                    Context.ServiceGroups.Add(data);
                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Result = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<ServiceGroupDto>> Update(ServiceGroupDto input)
        {
            var result = new ResultDto<ServiceGroupDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var sServiceGroup = Context.ServiceGroups.FirstOrDefault(f => f.Id == input.Id);
                    if (sServiceGroup == null)
                        ObjectMapper.Map(input, sServiceGroup);

                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Result = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<ServiceGroupDto>> Delete(Guid id)
        {
            var result = new ResultDto<ServiceGroupDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var serviceGroup = Context.ServiceGroups.SingleOrDefault(x => x.Id == id);
                    if (serviceGroup != null)
                    {
                        Context.ServiceGroups.Remove(serviceGroup);
                        await Context.SaveChangesAsync();
                        result.IsSucceeded = true;

                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public override async Task<PagedResultDto<ServiceGroupDto>> GetAll(GetAllServiceGroupInput input)
        {
            var result = new PagedResultDto<ServiceGroupDto>();

            try
            {
                result.Result = (from r in Context.ServiceGroups
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
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<ServiceGroupDto>> GetById(Guid id)
        {
            var result = new ResultDto<ServiceGroupDto>();

            try
            {
                var service = Context.ServiceGroups.FirstOrDefault(s => s.Id == id);
                result.Result = ObjectMapper.Map<ServiceGroupDto>(service);
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }
    }
}
