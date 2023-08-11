using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.ChapterICD10;
using HIS.Dtos.Dictionaries.ServiceUnit;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.ChapterICD10
{
    public class SChapterICD10Service : BaseSerivce, ISChapterICD10Service
    {
        public SChapterICD10Service(HISDbContext dbContext, IConfiguration config, IMapper mapper) : base(dbContext, config, mapper)
        {
        }

        public async Task<ApiResult<SChapterICD10Dto>> CreateOrEdit(SChapterICD10Dto input)
        {
            if (GuidHelper.IsNullOrEmpty(input.Id))
                return await Create(input);
            else
                return await Update(input);
        }

        private async Task<ApiResult<SChapterICD10Dto>> Create(SChapterICD10Dto input)
        {
            var result = new ApiResult<SChapterICD10Dto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();

                    var data = _mapper.Map<SChapterICD10>(input);

                    _dbContext.SChapterICD10s.Add(data);
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

        private async Task<ApiResult<SChapterICD10Dto>> Update(SChapterICD10Dto input)
        {
            var result = new ApiResult<SChapterICD10Dto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var sServiceChapterICD10 = _dbContext.SChapterICD10s.FirstOrDefault(f => f.Id == input.Id);
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

        public async Task<ApiResult<SChapterICD10Dto>> Delete(Guid id)
        {
            var result = new ApiResult<SChapterICD10Dto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var sServiceChapterICD10 = _dbContext.SChapterICD10s.SingleOrDefault(x => x.Id == id);
                    if (sServiceChapterICD10 != null)
                    {
                        _dbContext.SChapterICD10s.Remove(sServiceChapterICD10);
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

        public async Task<ApiResultList<SChapterICD10Dto>> GetAll(GetAllSChapterICD10Input input)
        {
            var result = new ApiResultList<SChapterICD10Dto>();

            try
            {
                result.Result = (from r in _dbContext.SChapterICD10s
                                 select new SChapterICD10Dto()
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

        public async Task<ApiResult<SChapterICD10Dto>> GetById(Guid id)
        {
            var result = new ApiResult<SChapterICD10Dto>();

            try
            {
                var service = _dbContext.SChapterICD10s.FirstOrDefault(s => s.Id == id);
                result.Result = _mapper.Map<SChapterICD10Dto>(service);
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
