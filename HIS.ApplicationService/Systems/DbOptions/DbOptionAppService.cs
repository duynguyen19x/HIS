using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Systems.DbOption;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Systems;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Systems.DbOptions
{
    public class DbOptionAppService : BaseCrudAppService<DbOptionDto, Guid?, GetAllDbOptionInput>, IDbOptionAppService
    {
        public DbOptionAppService(HISDbContext dbContext, IConfiguration config, IMapper mapper) 
            : base(dbContext, mapper)
        {
        }
        
        public override async Task<ResultDto<DbOptionDto>> Create(DbOptionDto input)
        {
            var result = new ResultDto<DbOptionDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();

                    var data = ObjectMapper.Map<DbOption>(input);
                    Context.DbOptions.Add(data);

                    var dataParent = Context.DbOptions.FirstOrDefault(w => w.Id == input.ParentId);
                    if (dataParent != null) { dataParent.IsParent = true; }
                    Context.DbOptions.Update(dataParent);
                    
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

        public override async Task<ResultDto<DbOptionDto>> Update(DbOptionDto input)
        {
            var result = new ResultDto<DbOptionDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var sServiceDbOption = Context.DbOptions.FirstOrDefault(f => f.Id == input.Id);
                    if (sServiceDbOption != null)
                    {
                        if (sServiceDbOption.ParentId != input.ParentId && !Context.DbOptions.Any(a => a.Id == sServiceDbOption.ParentId))
                        {
                            var dataOldParent = Context.DbOptions.FirstOrDefault(w => w.Id == sServiceDbOption.ParentId);
                            if (dataOldParent != null) { dataOldParent.IsParent = false; }
                            Context.DbOptions.Update(dataOldParent);
                        }
                        ObjectMapper.Map(input, sServiceDbOption);
                    }

                    var dataParent = Context.DbOptions.FirstOrDefault(w => w.Id == input.ParentId);
                    if (dataParent != null) { dataParent.IsParent = true; }
                    Context.DbOptions.Update(dataParent);

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

        public override async Task<ResultDto<DbOptionDto>> Delete(Guid? id)
        {
            var result = new ResultDto<DbOptionDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var sServiceDbOption10 = Context.DbOptions.SingleOrDefault(x => x.Id == id);
                    if (sServiceDbOption10 != null)
                    {
                        Context.DbOptions.Remove(sServiceDbOption10);
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

        public override async Task<PagedResultDto<DbOptionDto>> GetAll(GetAllDbOptionInput input)
        {
            var result = new PagedResultDto<DbOptionDto>();

            try
            {
                result.Result = (from r in Context.DbOptions
                                 select new DbOptionDto()
                                 {
                                     Id = r.Id,
                                     DbOptionId = r.DbOptionId,
                                     DbOptionValue = r.DbOptionValue,
                                     DbOptionType = r.DbOptionType,
                                     Description = r.Description,
                                     ParentId = r.ParentId,
                                     IsParent = r.IsParent,
                                 }).OrderBy(o => o.DbOptionId).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<DbOptionDto>> GetById(Guid? id)
        {
            var result = new ResultDto<DbOptionDto>();

            try
            {
                var service = Context.DbOptions.FirstOrDefault(s => s.Id == id);
                result.Result = ObjectMapper.Map<DbOptionDto>(service);
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public async Task<ResultDto<OptionValueDto>> GetMapOptions()
        {
            var result = new ResultDto<OptionValueDto>();
            var properties = result.GetType().GetProperties();
            foreach (var property in properties)
            {
                //switch (property.PropertyType)
                //{
                //    case:
                //        break;
                //    default:
                //        break;
                //}
            }

            return await Task.FromResult(result);
        }
    }
}
