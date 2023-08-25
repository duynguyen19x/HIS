using AutoMapper;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Gender;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.Gender
{
    public class SGenderService : BaseSerivce, ISGenderService
    {
        public SGenderService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, config, mapper)
        {

        }

        public async Task<ApiResult<SGenderDto>> CreateOrEdit(SGenderDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<SGenderDto>> Create(SGenderDto input)
        {
            var result = new ApiResult<SGenderDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = _mapper.Map<EntityFrameworkCore.Entities.Dictionaries.Gender>(input);
                    _dbContext.SGenders.Add(data);
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

        public async Task<ApiResult<SGenderDto>> Update(SGenderDto input)
        {
            var result = new ApiResult<SGenderDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var data = _mapper.Map<EntityFrameworkCore.Entities.Dictionaries.Gender>(input);
                    _dbContext.SGenders.Update(data);
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

        public async Task<ApiResult<SGenderDto>> Delete(Guid id)
        {
            var result = new ApiResult<SGenderDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var data = _dbContext.SGenders.SingleOrDefault(x => x.Id == id);
                    if (data != null)
                    {
                        _dbContext.SGenders.Remove(data);
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

        public async Task<ApiResultList<SGenderDto>> GetAll(GetAllSGenderInput input)
        {
            var result = new ApiResultList<SGenderDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.SGenders
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new SGenderDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Description = r.Description,
                                     Inactive = r.Inactive,
                                     SortOrder = r.SortOrder
                                 })
                                 .OrderBy(x => x.SortOrder)
                                 .ToList();
                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<SGenderDto>> GetById(Guid id)
        {
            var result = new ApiResult<SGenderDto>();

            var data = _dbContext.SGenders.SingleOrDefault(s => s.Id == id);
            if (data != null)
            {
                result.IsSuccessed = true;
                result.Result = new SGenderDto()
                {
                    Id = data.Id,
                    Code = data.Code,
                    Name = data.Name,
                    Description = data.Description,
                    SortOrder = data.SortOrder,
                    Inactive = data.Inactive
                };
            }

            return await Task.FromResult(result);
        }

    }
}
