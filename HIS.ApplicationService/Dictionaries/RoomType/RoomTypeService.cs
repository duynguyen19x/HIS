using AutoMapper;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.RoomType;
using HIS.EntityFrameworkCore;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.RoomType
{
    public class RoomTypeService : BaseSerivce, IRoomTypeService
    {
        public RoomTypeService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, config, mapper)
        {

        }

        public async Task<ApiResult<RoomTypeDto>> CreateOrEdit(RoomTypeDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<RoomTypeDto>> Create(RoomTypeDto input)
        {
            var result = new ApiResult<RoomTypeDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    //input.Id = Guid.NewGuid();
                    var data = _mapper.Map<EntityFrameworkCore.Entities.Dictionaries.RoomType>(input);
                    _dbContext.RoomTypes.Add(data);
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

        public async Task<ApiResult<RoomTypeDto>> Update(RoomTypeDto input)
        {
            var result = new ApiResult<RoomTypeDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var data = _mapper.Map<EntityFrameworkCore.Entities.Dictionaries.RoomType>(input);
                    _dbContext.RoomTypes.Update(data);
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

        public async Task<ApiResult<RoomTypeDto>> Delete(int id)
        {
            var result = new ApiResult<RoomTypeDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var data = _dbContext.RoomTypes.SingleOrDefault(x => x.Id == id);
                    if (data != null)
                    {
                        _dbContext.RoomTypes.Remove(data);
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

        public async Task<ApiResultList<RoomTypeDto>> GetAll(GetAllRoomTypeInput input)
        {
            var result = new ApiResultList<RoomTypeDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.RoomTypes
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new RoomTypeDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Description = r.Description,
                                     SortOrder = r.SortOrder,
                                     Inactive = r.Inactive
                                 })
                                 .OrderBy(o => o.SortOrder)
                                 .ThenBy(o => o.Code)
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

        public async Task<ApiResult<RoomTypeDto>> GetById(int id)
        {
            var result = new ApiResult<RoomTypeDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.RoomTypes
                                 where r.Id == id
                                 select new RoomTypeDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Description = r.Description,
                                     SortOrder = r.SortOrder,
                                     Inactive = r.Inactive
                                 })
                                 .SingleOrDefault();
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }
    }
}
