using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ChapterICD10;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.ChapterICD10
{
    public class ChapterIcdService : BaseSerivce, IChapterIcdService
    {
        public ChapterIcdService(HISDbContext dbContext, IConfiguration config, IMapper mapper) : base(dbContext, config, mapper)
        {
        }

        public async Task<ApiResult<ChapterIcdDto>> CreateOrEdit(ChapterIcdDto input)
        {
            if (GuidHelper.IsNullOrEmpty(input.Id))
                return await Create(input);
            else
                return await Update(input);
        }

        private async Task<ApiResult<ChapterIcdDto>> Create(ChapterIcdDto input)
        {
            var result = new ApiResult<ChapterIcdDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();

                    var data = _mapper.Map<ChapterIcd>(input);

                    _dbContext.SChapterIcds.Add(data);
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

        private async Task<ApiResult<ChapterIcdDto>> Update(ChapterIcdDto input)
        {
            var result = new ApiResult<ChapterIcdDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var sServiceChapterICD10 = _dbContext.SChapterIcds.FirstOrDefault(f => f.Id == input.Id);
                    if (sServiceChapterICD10 == null)
                        _mapper.Map(input, sServiceChapterICD10);

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

        public async Task<ApiResult<ChapterIcdDto>> Delete(Guid id)
        {
            var result = new ApiResult<ChapterIcdDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var sServiceChapterICD10 = _dbContext.SChapterIcds.SingleOrDefault(x => x.Id == id);
                    if (sServiceChapterICD10 != null)
                    {
                        _dbContext.SChapterIcds.Remove(sServiceChapterICD10);
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

        public async Task<ApiResultList<ChapterIcdDto>> GetAll(GetAllChapterIcdInput input)
        {
            var result = new ApiResultList<ChapterIcdDto>();

            try
            {
                result.Result = (from r in _dbContext.SChapterIcds
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
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<ChapterIcdDto>> GetById(Guid id)
        {
            var result = new ApiResult<ChapterIcdDto>();

            try
            {
                var service = _dbContext.SChapterIcds.FirstOrDefault(s => s.Id == id);
                result.Result = _mapper.Map<ChapterIcdDto>(service);
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
