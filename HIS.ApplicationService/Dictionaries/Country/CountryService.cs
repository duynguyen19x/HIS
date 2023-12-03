using HIS.Dtos.Dictionaries.Country;
using Microsoft.Extensions.Configuration;
using AutoMapper;
using HIS.EntityFrameworkCore;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using Microsoft.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionaries;

namespace HIS.ApplicationService.Dictionaries.Country
{
    public class CountryService : BaseCrudAppService<CountryDto, Guid?, GetAllCountryInput>, ICountryService
    {
        public CountryService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, mapper)
        {

        }

        public override async Task<ResultDto<CountryDto>> Create(CountryDto input)
        {
            var result = new ResultDto<CountryDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = ObjectMapper.Map<National>(input);
                    Context.Nationals.Add(data);
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

        public override async Task<ResultDto<CountryDto>> Update(CountryDto input)
        {
            var result = new ResultDto<CountryDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var data = ObjectMapper.Map<National>(input);
                    Context.Nationals.Update(data);
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

        public override async Task<ResultDto<CountryDto>> Delete(Guid? id)
        {
            var result = new ResultDto<CountryDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var job = Context.Nationals.SingleOrDefault(x => x.Id == id);
                    if (job != null)
                    {
                        Context.Nationals.Remove(job);
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

        public override async Task<PagedResultDto<CountryDto>> GetAll(GetAllCountryInput input)
        {
            var result = new PagedResultDto<CountryDto>();
            try
            {
                result.IsSucceeded = true;
                result.Items = (from r in Context.Nationals
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new CountryDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Inactive = r.Inactive
                                 }).OrderBy(o => o.Code).ToList();
                result.TotalCount = result.Items.Count;
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<CountryDto>> GetById(Guid? id)
        {
            var result = new ResultDto<CountryDto>();

            var data = Context.Nationals.SingleOrDefault(s => s.Id == id);
            if (data != null)
            {
                result.IsSucceeded = true;
                result.Item = ObjectMapper.Map<CountryDto>(data);
            }

            return await Task.FromResult(result);
        }
    }
}
