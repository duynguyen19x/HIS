using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Dictionaries.RoomType;
using HIS.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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
                    var data = ObjectMapper.Map<EntityFrameworkCore.Entities.Dictionaries.RoomType>(input);
                    Context.RoomTypes.Add(data);
                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Item = input;

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
                    var data = ObjectMapper.Map<EntityFrameworkCore.Entities.Dictionaries.RoomType>(input);
                    Context.RoomTypes.Update(data);
                    await Context.SaveChangesAsync();

                    result.IsSucceeded = true;
                    result.Item = input;

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
                result.IsSucceeded = true;
                result.Items = (from r in Context.RoomTypes
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
                result.TotalCount = result.Items.Count;
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
                result.IsSucceeded = true;
                result.Item = (from r in Context.RoomTypes
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
