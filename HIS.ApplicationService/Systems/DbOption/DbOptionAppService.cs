using AutoMapper;
using HIS.Core.Linq;
using HIS.Dtos.Commons;
using HIS.Dtos.Systems.DbOption;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Systems.DbOption
{
    public class DbOptionAppService : BaseSerivce, IDbOptionAppService
    {
        public DbOptionAppService(HISDbContext dbContext, IConfiguration config, IMapper mapper) : base(dbContext, config, mapper)
        {
        }

        public async Task<ApiResult<DbOptionDto>> CreateOrEdit(DbOptionDto input)
        {
            if (GuidHelper.IsNullOrEmpty(input.Id))
                return await Create(input);
            else
                return await Update(input);
        }

        private async Task<ApiResult<DbOptionDto>> Create(DbOptionDto input)
        {
            var result = new ApiResult<DbOptionDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();

                    var data = _mapper.Map<EntityFrameworkCore.Entities.Systems.DbOption>(input);

                    _dbContext.DbOptions.Add(data);

                    var dataParent = _dbContext.DbOptions.FirstOrDefault(w => w.Id == input.ParentId);
                    if (dataParent != null) { dataParent.IsParent = true; }
                    _dbContext.DbOptions.Update(dataParent);
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

        private async Task<ApiResult<DbOptionDto>> Update(DbOptionDto input)
        {
            var result = new ApiResult<DbOptionDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var sServiceDbOption = _dbContext.DbOptions.FirstOrDefault(f => f.Id == input.Id);
                    if (sServiceDbOption != null)
                    {
                        if (sServiceDbOption.ParentId != input.ParentId && !_dbContext.DbOptions.Any(a => a.Id == sServiceDbOption.ParentId))
                        {
                            var dataOldParent = _dbContext.DbOptions.FirstOrDefault(w => w.Id == sServiceDbOption.ParentId);
                            if (dataOldParent != null) { dataOldParent.IsParent = false; }
                            _dbContext.DbOptions.Update(dataOldParent);
                        }
                        _mapper.Map(input, sServiceDbOption);
                    }    

                    var dataParent = _dbContext.DbOptions.FirstOrDefault(w => w.Id == input.ParentId);
                    if (dataParent != null) { dataParent.IsParent = true; }
                    _dbContext.DbOptions.Update(dataParent);

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

        public async Task<ApiResult<DbOptionDto>> Delete(Guid id)
        {
            var result = new ApiResult<DbOptionDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var sServiceDbOption10 = _dbContext.DbOptions.SingleOrDefault(x => x.Id == id);
                    if (sServiceDbOption10 != null)
                    {
                        _dbContext.DbOptions.Remove(sServiceDbOption10);
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

        public async Task<ApiResultList<DbOptionDto>> GetAll(GetAllDbOptionInput input)
        {
            var result = new ApiResultList<DbOptionDto>();

            try
            {
                result.Result = (from r in _dbContext.DbOptions
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
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<DbOptionDto>> GetById(Guid id)
        {
            var result = new ApiResult<DbOptionDto>();

            try
            {
                var service = _dbContext.DbOptions.FirstOrDefault(s => s.Id == id);
                result.Result = _mapper.Map<DbOptionDto>(service);
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<OptionValueDto>> GetMapOptions()
        {
            var result = new ApiResult<OptionValueDto>();
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
