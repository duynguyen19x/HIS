using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Core.Linq.Extensions;
using HIS.Dtos.Dictionaries.ServiceGroupHeIn;
using HIS.EntityFrameworkCore;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionaries.ServiceGroupHeIn
{
    public class ServiceGroupHeInService : BaseCrudAppService<ServiceGroupHeInDto, Guid, GetAllServiceGroupHeInInput>, IServiceGroupHeInService
    {
        public ServiceGroupHeInService(HISDbContext dbContext, IMapper mapper) 
            : base(dbContext, mapper)
        {
        }

        public override async Task<ResultDto<ServiceGroupHeInDto>> Create(ServiceGroupHeInDto input)
        {
            var result = new ResultDto<ServiceGroupHeInDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();

                    var data = ObjectMapper.Map<EntityFrameworkCore.Entities.Categories.Services.ServiceGroupHeIn>(input);

                    Context.ServiceGroupHeIns.Add(data);
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

        public override async Task<ResultDto<ServiceGroupHeInDto>> Update(ServiceGroupHeInDto input)
        {
            var result = new ResultDto<ServiceGroupHeInDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var sServiceGroupHeIn = Context.ServiceGroupHeIns.FirstOrDefault(f => f.Id == input.Id);
                    if (sServiceGroupHeIn == null)
                        ObjectMapper.Map(input, sServiceGroupHeIn);

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

        public override async Task<ResultDto<ServiceGroupHeInDto>> Delete(Guid id)
        {
            var result = new ResultDto<ServiceGroupHeInDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var sServiceGroupHeIn = Context.ServiceGroupHeIns.SingleOrDefault(x => x.Id == id);
                    if (sServiceGroupHeIn != null)
                    {
                        Context.ServiceGroupHeIns.Remove(sServiceGroupHeIn);
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

        public override async Task<PagedResultDto<ServiceGroupHeInDto>> GetAll(GetAllServiceGroupHeInInput input)
        {
            var result = new PagedResultDto<ServiceGroupHeInDto>();

            try
            {
                result.Result = (from r in Context.ServiceGroupHeIns
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
                result.IsSucceeded = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<ServiceGroupHeInDto>> GetById(Guid id)
        {
            var result = new ResultDto<ServiceGroupHeInDto>();

            try
            {
                var service = Context.ServiceGroupHeIns.FirstOrDefault(s => s.Id == id);
                result.Result = ObjectMapper.Map<ServiceGroupHeInDto>(service);
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }
    }
}
