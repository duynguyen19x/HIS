using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Dictionaries.ServiceUnit;
using HIS.EntityFrameworkCore;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.Unit
{
    public class UnitService : BaseCrudAppService<UnitDto, Guid?, GetAllUnitInput>, IUnitService
    {
        public UnitService(HISDbContext dbContext, IConfiguration config, IMapper mapper) 
            : base(dbContext, mapper)
        {
        }

        public override async Task<ResultDto<UnitDto>> Create(UnitDto input)
        {
            var result = new ResultDto<UnitDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();

                    var data = ObjectMapper.Map<EntityFrameworkCore.Entities.Dictionaries.Unit>(input);

                    Context.Units.Add(data);
                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Item = input;

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

        public override async Task<ResultDto<UnitDto>> Update(UnitDto input)
        {
            var result = new ResultDto<UnitDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var sServiceUnit = Context.Units.FirstOrDefault(f => f.Id == input.Id);
                    if (sServiceUnit == null)
                        ObjectMapper.Map(input, sServiceUnit);

                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Item = input;

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

        public override async Task<ResultDto<UnitDto>> Delete(Guid? id)
        {
            var result = new ResultDto<UnitDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var sServiceUnit = Context.Units.SingleOrDefault(x => x.Id == id);
                    if (sServiceUnit != null)
                    {
                        Context.Units.Remove(sServiceUnit);
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

        public override async Task<PagedResultDto<UnitDto>> GetAll(GetAllUnitInput input)
        {
            var result = new PagedResultDto<UnitDto>();

            try
            {
                result.Items = (from r in Context.Units
                                 select new UnitDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Inactive = r.Inactive,
                                     SortOrder = r.SortOrder,
                                 }).WhereIf(input.InactiveFilter != null, w => w.Inactive == input.InactiveFilter).OrderBy(o => o.SortOrder).ToList();

                result.TotalCount = result.Items.Count;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<UnitDto>> GetById(Guid? id)
        {
            var result = new ResultDto<UnitDto>();

            try
            {
                var service = Context.ServiceGroups.FirstOrDefault(s => s.Id == id);
                result.Item = ObjectMapper.Map<UnitDto>(service);
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }
    }
}
