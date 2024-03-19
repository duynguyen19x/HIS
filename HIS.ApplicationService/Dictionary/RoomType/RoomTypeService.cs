using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.RoomType;
using HIS.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;

namespace HIS.ApplicationService.Dictionaries.RoomType
{
    public class RoomTypeService : BaseCrudAppService<RoomTypeDto, int, GetAllRoomTypeInput>, IRoomTypeService
    {
        public RoomTypeService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, mapper)
        {

        }

        public override async Task<ResultDto<RoomTypeDto>> Create(RoomTypeDto input)
        {
            var result = new ResultDto<RoomTypeDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    //input.Id = Guid.NewGuid();
                    var data = ObjectMapper.Map<EntityFrameworkCore.Entities.Dictionaries.DIRoomType>(input);
                    Context.RoomTypes.Add(data);
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

        public override async Task<ResultDto<RoomTypeDto>> Update(RoomTypeDto input)
        {
            var result = new ResultDto<RoomTypeDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var data = ObjectMapper.Map<EntityFrameworkCore.Entities.Dictionaries.DIRoomType>(input);
                    Context.RoomTypes.Update(data);
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

        public override async Task<ResultDto<RoomTypeDto>> Delete(int id)
        {
            var result = new ResultDto<RoomTypeDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var data = Context.RoomTypes.SingleOrDefault(x => x.Id == id);
                    if (data != null)
                    {
                        Context.RoomTypes.Remove(data);
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

        public override async Task<PagedResultDto<RoomTypeDto>> GetAll(GetAllRoomTypeInput input)
        {
            var result = new PagedResultDto<RoomTypeDto>();
            try
            {
                var filter = Context.RoomTypes.AsNoTracking()
                    .WhereIf(!string.IsNullOrEmpty(input.RoomTypeCodeFilter), x => x.Code == input.RoomTypeCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.RoomTypeNameFilter), x => x.Name == input.RoomTypeNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.OrderBy(x => x.SortOrder).PageBy(input).ToList();

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<RoomTypeDto>>(paged);
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<RoomTypeDto>> GetById(int id)
        {
            var result = new ResultDto<RoomTypeDto>();
            try
            {
                result.Result = ObjectMapper.Map<RoomTypeDto>(await Context.RoomTypes.SingleOrDefaultAsync(x => x.Id == id));
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }
    }
}
