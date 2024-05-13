using HIS.Dtos.Dictionaries.ChapterICD10;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;
using HIS.Core.Domain.Repositories;
using HIS.Core.Application.Services;
using System.Transactions;

namespace HIS.ApplicationService.Dictionaries.ChapterICD10
{
    public class ChapterIcdService : BaseAppService, IChapterIcdService
    {
        private readonly IRepository<ChapterIcd, Guid> _chapterIcdRepository;

        public ChapterIcdService(IRepository<ChapterIcd, Guid> chapterIcdRepository) 
        {
            _chapterIcdRepository = chapterIcdRepository;
        }

        public virtual async Task<ResultDto<ChapterIcdDto>> CreateOrEdit(ChapterIcdDto input)
        {
            if (Check.IsNullOrDefault(input.Id))
            {
                return await Create(input);
            }
            else
            {
                return await Update(input);
            }
        }

        public virtual async Task<ResultDto<ChapterIcdDto>> Create(ChapterIcdDto input)
        {
            var result = new ResultDto<ChapterIcdDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();

                    var data = ObjectMapper.Map<ChapterIcd>(input);

                    await _chapterIcdRepository.InsertAsync(data);

                    await unitOfWork.CompleteAsync();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<ChapterIcdDto>> Update(ChapterIcdDto input)
        {
            var result = new ResultDto<ChapterIcdDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var sServiceChapterICD10 = _chapterIcdRepository.FirstOrDefault(f => f.Id == input.Id);
                    if (sServiceChapterICD10 == null)
                        ObjectMapper.Map(input, sServiceChapterICD10);

                    await unitOfWork.CompleteAsync();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<ChapterIcdDto>> Delete(Guid id)
        {
            var result = new ResultDto<ChapterIcdDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var sServiceChapterICD10 = await _chapterIcdRepository.FirstOrDefaultAsync(x => x.Id == id);
                    if (sServiceChapterICD10 != null)
                    {
                        _chapterIcdRepository.Delete(sServiceChapterICD10);

                        await unitOfWork.CompleteAsync();
                        result.Success(null);
                    }
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<PagedResultDto<ChapterIcdDto>> GetAll(GetAllChapterIcdInput input)
        {
            var result = new PagedResultDto<ChapterIcdDto>();

            try
            {
                result.Result = (from r in _chapterIcdRepository.GetAll()
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
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<ChapterIcdDto>> GetById(Guid id)
        {
            var result = new ResultDto<ChapterIcdDto>();

            try
            {
                var service = await _chapterIcdRepository.FirstOrDefaultAsync(s => s.Id == id);
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
