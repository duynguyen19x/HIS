﻿using AutoMapper;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Room;
using HIS.EntityFrameworkCore;
using HIS.Models.Commons;
using HIS.Utilities.Enums;
using Microsoft.Extensions.Configuration;

namespace HIS.ApplicationService.Dictionaries.Room
{
    internal class RoomService : BaseSerivce, IRoomService
    {
        public RoomService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, config, mapper)
        {

        }

        public async Task<ApiResult<RoomDto>> CreateOrEdit(RoomDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<RoomDto>> Create(RoomDto input)
        {
            var result = new ApiResult<RoomDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = _mapper.Map<EntityFrameworkCore.Entities.Dictionaries.Room>(input);
                    _dbContext.Rooms.Add(data);
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

        public async Task<ApiResult<RoomDto>> Update(RoomDto input)
        {
            var result = new ApiResult<RoomDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var data = _mapper.Map<EntityFrameworkCore.Entities.Dictionaries.Room>(input);
                    _dbContext.Rooms.Update(data);
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

        public async Task<ApiResult<RoomDto>> Delete(Guid id)
        {
            var result = new ApiResult<RoomDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var department = _dbContext.Rooms.SingleOrDefault(x => x.Id == id);
                    if (department != null)
                    {
                        _dbContext.Rooms.Remove(department);
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

        public async Task<ApiResultList<RoomDto>> GetAll(GetAllRoomInput input)
        {
            var result = new ApiResultList<RoomDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.Rooms
                                 join t in _dbContext.RoomTypes on r.RoomTypeId equals t.Id
                                 join d in _dbContext.Departments on r.DepartmentId equals d.Id 
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
                                     RoomTypeCode = t.Code,
                                     RoomTypeName = t.Name,
                                     DepartmentId = r.DepartmentId,
                                     DepartmentCode = d.DepartmentCode,
                                     DepartmentName = d.DepartmentName,
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
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<RoomDto>> GetById(Guid id)
        {
            var result = new ApiResult<RoomDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.Rooms
                                 join t in _dbContext.RoomTypes on r.RoomTypeId equals t.Id
                                 join d in _dbContext.Departments on r.DepartmentId equals d.Id
                                 where r.Id == id
                                 select new RoomDto()
                                 {
                                     Id = r.Id,
                                     RoomCode = r.RoomCode,
                                     MohCode = r.MohCode,
                                     RoomName = r.RoomName,
                                     RoomTypeId = r.RoomTypeId,
                                     RoomTypeCode = t.Code,
                                     RoomTypeName = t.Name,
                                     DepartmentId = r.DepartmentId,
                                     DepartmentCode = d.DepartmentCode,
                                     DepartmentName = d.DepartmentName,
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

        public async Task<ApiResultList<RoomDto>> GetByStocks()
        {
            var result = new ApiResultList<RoomDto>();
            try
            {
                result.Result = (from r in _dbContext.Rooms
                                 join t in _dbContext.RoomTypes on r.RoomTypeId equals t.Id
                                 join d in _dbContext.Departments on r.DepartmentId equals d.Id
                                 where d.DepartmentTypeId == (int)DepartmentTypes.PharmacyDepartment
                                 select new RoomDto()
                                 {
                                     Id = r.Id,
                                     RoomCode = r.RoomCode,
                                     MohCode = r.MohCode,
                                     RoomName = r.RoomName,
                                     RoomTypeId = r.RoomTypeId,
                                     RoomTypeCode = t.Code,
                                     RoomTypeName = t.Name,
                                     DepartmentId = r.DepartmentId,
                                     DepartmentCode = d.DepartmentCode,
                                     DepartmentName = d.DepartmentName,
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
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }
    }
}
