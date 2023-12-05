using HIS.Dtos.Dictionaries.Nationals;
using Microsoft.Extensions.Configuration;
using AutoMapper;
using HIS.EntityFrameworkCore;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using Microsoft.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionaries;

namespace HIS.ApplicationService.Dictionaries.Country
{
    public class CountryService : BaseCrudAppService<NationalDto, Guid?, GetAllNationalInputDto>, ICountryService
    {
        public CountryService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, mapper)
        {

        }

        public override async Task<ResultDto<NationalDto>> Create(NationalDto input)
        {
            var result = new ResultDto<NationalDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = ObjectMapper.Map<National>(input);
                    Context.Nationals.Add(data);
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

        public override async Task<ResultDto<NationalDto>> Update(NationalDto input)
        {
            var result = new ResultDto<NationalDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var data = ObjectMapper.Map<National>(input);
                    Context.Nationals.Update(data);
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

        public override async Task<ResultDto<NationalDto>> Delete(Guid? id)
        {
            var result = new ResultDto<NationalDto>();
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

        public override async Task<PagedResultDto<NationalDto>> GetAll(GetAllNationalInputDto input)
        {
            var result = new PagedResultDto<NationalDto>();
            try
            {
                result.IsSucceeded = true;
                result.Result = (from r in Context.Nationals
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new NationalDto()
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

        public override async Task<ResultDto<NationalDto>> GetById(Guid? id)
        {
            var result = new ResultDto<NationalDto>();

            var data = Context.Nationals.SingleOrDefault(s => s.Id == id);
            if (data != null)
            {
                result.IsSucceeded = true;
                result.Result = ObjectMapper.Map<NationalDto>(data);
            }

            return await Task.FromResult(result);
        }
    }
}
