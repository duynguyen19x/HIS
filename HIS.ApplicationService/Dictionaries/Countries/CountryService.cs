using AutoMapper;
using HIS.EntityFrameworkCore;
using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.Countries;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionaries.Countries
{
    public class CountryService : BaseCrudAppService<CountryDto, Guid?, GetAllCountryInputDto>, ICountryAppService
    {
        public CountryService(HISDbContext dbContext, IMapper mapper)
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
                    var data = base.ObjectMapper.Map<EntityFrameworkCore.Entities.Dictionaries.DICountry>(input);
                    Context.Countries.Add(data);
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

        public override async Task<ResultDto<CountryDto>> Update(CountryDto input)
        {
            var result = new ResultDto<CountryDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var data = base.ObjectMapper.Map<EntityFrameworkCore.Entities.Dictionaries.DICountry>(input);
                    Context.Countries.Update(data);
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

        public override async Task<ResultDto<CountryDto>> Delete(Guid? id)
        {
            var result = new ResultDto<CountryDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var job = Context.Countries.SingleOrDefault(x => x.Id == id);
                    if (job != null)
                    {
                        Context.Countries.Remove(job);
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

        public override async Task<PagedResultDto<CountryDto>> GetAll(GetAllCountryInputDto input)
        {
            var result = new PagedResultDto<CountryDto>();
            try
            {
                result.IsSucceeded = true;
                result.Result = (from r in Context.Countries
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
                result.TotalCount = result.Result.Count;
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

            var data = Context.Countries.SingleOrDefault(s => s.Id == id);
            if (data != null)
            {
                result.IsSucceeded = true;
                result.Result = ObjectMapper.Map<CountryDto>(data);
            }

            return await Task.FromResult(result);
        }
    }
}
