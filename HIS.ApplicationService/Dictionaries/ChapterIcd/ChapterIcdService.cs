using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Core.Services.Dto;
using HIS.Core.Linq.Extensions;
using HIS.Dtos.Dictionaries.ChapterICD10;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.ChapterICD10
{
    public class ChapterIcdService : BaseCrudAppService<ChapterIcdDto, Guid?, GetAllChapterIcdInput>, IChapterIcdService
    {
        public ChapterIcdService(HISDbContext dbContext, IConfiguration config, IMapper mapper) 
            : base(dbContext, mapper)
        {
        }

        public override async Task<ResultDto<ChapterIcdDto>> Create(ChapterIcdDto input)
        {
            var result = new ResultDto<ChapterIcdDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();

                    var data = ObjectMapper.Map<ChapterIcd>(input);

                    Context.ChapterIcds.Add(data);
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

        public override async Task<ResultDto<ChapterIcdDto>> Update(ChapterIcdDto input)
        {
            var result = new ResultDto<ChapterIcdDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var sServiceChapterICD10 = Context.ChapterIcds.FirstOrDefault(f => f.Id == input.Id);
                    if (sServiceChapterICD10 == null)
                        ObjectMapper.Map(input, sServiceChapterICD10);

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

        public override async Task<ResultDto<ChapterIcdDto>> Delete(Guid? id)
        {
            var result = new ResultDto<ChapterIcdDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var sServiceChapterICD10 = Context.ChapterIcds.SingleOrDefault(x => x.Id == id);
                    if (sServiceChapterICD10 != null)
                    {
                        Context.ChapterIcds.Remove(sServiceChapterICD10);
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

        public override async Task<PagedResultDto<ChapterIcdDto>> GetAll(GetAllChapterIcdInput input)
        {
            var result = new PagedResultDto<ChapterIcdDto>();

            try
            {
                result.Result = (from r in Context.ChapterIcds
                                 select new ChapterIcdDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Inactive = r.Inactive,
                                     SortOrder = r.SortOrder,
                                 }).WhereIf(input.InactiveFilter != null, w => w.Inactive == input.InactiveFilter).OrderBy(o => o.SortOrder).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSucceeded = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<ChapterIcdDto>> GetById(Guid? id)
        {
            var result = new ResultDto<ChapterIcdDto>();

            try
            {
                var service = Context.ChapterIcds.FirstOrDefault(s => s.Id == id);
                result.Result = ObjectMapper.Map<ChapterIcdDto>(service);
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }
    }
}
