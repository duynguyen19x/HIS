using AutoMapper;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Department;
using HIS.Dtos.Dictionaries.Room;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Models.Commons;
using HIS.Utilities.Enums;
using HIS.Utilities.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.Room
{
    internal class SRoomService : BaseSerivce, ISRoomService
    {
        public SRoomService(HISDbContext dbContext, IConfiguration config, IMapper mapper)
            : base(dbContext, config, mapper)
        {

        }

        public async Task<ApiResult<SRoomDto>> CreateOrEdit(SRoomDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<SRoomDto>> Create(SRoomDto input)
        {
            var result = new ApiResult<SRoomDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = _mapper.Map<SRoom>(input);
                    _dbContext.SRooms.Add(data);
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

        public async Task<ApiResult<SRoomDto>> Update(SRoomDto input)
        {
            var result = new ApiResult<SRoomDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var data = _mapper.Map<SRoom>(input);
                    _dbContext.SRooms.Update(data);
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

        public async Task<ApiResult<SRoomDto>> Delete(Guid id)
        {
            var result = new ApiResult<SRoomDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var department = _dbContext.SRooms.SingleOrDefault(x => x.Id == id);
                    if (department != null)
                    {
                        _dbContext.SRooms.Remove(department);
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

        public async Task<ApiResultList<SRoomDto>> GetAll(GetAllSRoomInput input)
        {
            var result = new ApiResultList<SRoomDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.SRooms
                                 join t in _dbContext.SRoomTypes on r.RoomTypeId equals t.Id
                                 join d in _dbContext.SDepartments on r.DepartmentId equals d.Id 
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.DepartmentIdFilter == null || r.DepartmentId == input.DepartmentIdFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new SRoomDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     MohCode = r.MohCode,
                                     Name = r.Name,
                                     RoomTypeId = r.RoomTypeId,
                                     RoomTypeCode = t.Code,
                                     RoomTypeName = t.Name,
                                     DepartmentId = r.DepartmentId,
                                     DepartmentCode = d.Code,
                                     DepartmentName = d.Name,
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

        public async Task<ApiResult<SRoomDto>> GetById(Guid id)
        {
            var result = new ApiResult<SRoomDto>();
            try
            {
                result.IsSuccessed = true;
                result.Result = (from r in _dbContext.SRooms
                                 join t in _dbContext.SRoomTypes on r.RoomTypeId equals t.Id
                                 join d in _dbContext.SDepartments on r.DepartmentId equals d.Id
                                 where r.Id == id
                                 select new SRoomDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     MohCode = r.MohCode,
                                     Name = r.Name,
                                     RoomTypeId = r.RoomTypeId,
                                     RoomTypeCode = t.Code,
                                     RoomTypeName = t.Name,
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
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResultList<SRoomDto>> GetByStocks()
        {
            var result = new ApiResultList<SRoomDto>();
            try
            {
                result.Result = (from r in _dbContext.SRooms
                                 join t in _dbContext.SRoomTypes on r.RoomTypeId equals t.Id
                                 join d in _dbContext.SDepartments on r.DepartmentId equals d.Id
                                 where d.DepartmentTypeId == (int)DepartmentTypes.PharmacyDepartment
                                 select new SRoomDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     MohCode = r.MohCode,
                                     Name = r.Name,
                                     RoomTypeId = r.RoomTypeId,
                                     RoomTypeCode = t.Code,
                                     RoomTypeName = t.Name,
                                     DepartmentId = r.DepartmentId,
                                     DepartmentCode = d.Code,
                                     DepartmentName = d.Name,
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
    }
}
