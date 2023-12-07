using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Dictionaries.Room;
using HIS.EntityFrameworkCore;
using HIS.Utilities.Enums;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.Room
{
    internal class RoomAppService : BaseCrudAppService<RoomDto, Guid?, GetAllRoomInput>, IRoomAppService
    {
        public RoomAppService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, mapper)
        {
        }

        public override async Task<ResultDto<RoomDto>> Create(RoomDto input)
        {
            var result = new ResultDto<RoomDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = ObjectMapper.Map<EntityFrameworkCore.Entities.Dictionaries.Room>(input);
                    Context.Rooms.Add(data);
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

        public override async Task<ResultDto<RoomDto>> Update(RoomDto input)
        {
            var result = new ResultDto<RoomDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var data = ObjectMapper.Map<EntityFrameworkCore.Entities.Dictionaries.Room>(input);
                    Context.Rooms.Update(data);
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

        public override async Task<ResultDto<RoomDto>> Delete(Guid? id)
        {
            var result = new ResultDto<RoomDto>();
            using (var transaction = Context.Database.BeginTransaction())
            {
                try
                {
                    var department = Context.Rooms.SingleOrDefault(x => x.Id == id);
                    if (department != null)
                    {
                        Context.Rooms.Remove(department);
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

        public override async Task<PagedResultDto<RoomDto>> GetAll(GetAllRoomInput input)
        {
            var result = new PagedResultDto<RoomDto>();
            try
            {
                result.IsSucceeded = true;
                result.Result = (from r in Context.Rooms
                                 join t in Context.RoomTypes on r.RoomTypeId equals t.Id
                                 join d in Context.Departments on r.DepartmentId equals d.Id 
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.RoomName == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.RoomCode == input.CodeFilter)
                                     && (input.DepartmentIdFilter == null || r.DepartmentId == input.DepartmentIdFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new RoomDto()
                                 {
                                     Id = r.Id,
                                     RoomCode = r.RoomCode,
                                     MohCode = r.MohCode,
                                     RoomName = r.RoomName,
                                     RoomTypeId = r.RoomTypeId,
                                     RoomTypeCode = t.RoomTypeCode,
                                     RoomTypeName = t.RoomTypeName,
                                     DepartmentId = r.DepartmentId,
                                     DepartmentCode = d.Code,
                                     DepartmentName = d.Name,
                                     Description = r.Description,
                                     SortOrder = r.SortOrder,
                                     Inactive = r.Inactive
                                 })
                                 .OrderBy(o => o.SortOrder)
                                 .ThenBy(o => o.DepartmentCode)
                                 .ToList();
                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public override async Task<ResultDto<RoomDto>> GetById(Guid? id)
        {
            var result = new ResultDto<RoomDto>();
            try
            {
                result.IsSucceeded = true;
                result.Result = (from r in Context.Rooms
                                 join t in Context.RoomTypes on r.RoomTypeId equals t.Id
                                 join d in Context.Departments on r.DepartmentId equals d.Id
                                 where r.Id == id
                                 select new RoomDto()
                                 {
                                     Id = r.Id,
                                     RoomCode = r.RoomCode,
                                     MohCode = r.MohCode,
                                     RoomName = r.RoomName,
                                     RoomTypeId = r.RoomTypeId,
                                     RoomTypeCode = t.RoomTypeCode,
                                     RoomTypeName = t.RoomTypeName,
                                     DepartmentId = r.DepartmentId,
                                     DepartmentCode = d.Code,
                                     DepartmentName = d.Name,
                                     Description = r.Description,
                                     SortOrder = r.SortOrder,
                                     Inactive = r.Inactive
                                 })
                                 .SingleOrDefault();
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public async Task<PagedResultDto<RoomDto>> GetByStocks()
        {
            var result = new PagedResultDto<RoomDto>();
            try
            {
                result.Result = (from r in Context.Rooms
                                 join t in Context.RoomTypes on r.RoomTypeId equals t.Id
                                 join d in Context.Departments on r.DepartmentId equals d.Id
                                 where d.DepartmentTypeId == (int)DepartmentTypes.PharmacyDepartment
                                 select new RoomDto()
                                 {
                                     Id = r.Id,
                                     RoomCode = r.RoomCode,
                                     MohCode = r.MohCode,
                                     RoomName = r.RoomName,
                                     RoomTypeId = r.RoomTypeId,
                                     RoomTypeCode = t.RoomTypeCode,
                                     RoomTypeName = t.RoomTypeName,
                                     DepartmentId = r.DepartmentId,
                                     DepartmentCode = d.Code,
                                     DepartmentName = d.Name,
                                     Description = r.Description,
                                     SortOrder = r.SortOrder,
                                     Inactive = r.Inactive
                                 })
                                 .OrderBy(o => o.SortOrder)
                                 .ThenBy(o => o.DepartmentCode)
                                 .ToList();
                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }
    }
}
