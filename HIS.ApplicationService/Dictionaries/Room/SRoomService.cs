using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Department;
using HIS.Dtos.Dictionaries.Room;
using HIS.EntityFrameworkCore.DbContexts;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.Room
{
    internal class SRoomService : BaseSerivce, ISRoomService
    {
        public SRoomService(HIS_DbContext dbContext, IConfiguration config)
            : base(dbContext, config)
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
                    var department = new SRoom()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Description = input.Description,
                        DepartmentId = input.DepartmentId,
                        Inactive = input.Inactive
                    };
                    _dbContext.SRooms.Add(department);
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
                    var department = new SRoom()
                    {
                        Id = input.Id.GetValueOrDefault(),
                        Code = input.Code,
                        Name = input.Name,
                        Description = input.Description,
                        DepartmentId = input.DepartmentId,
                        Inactive = input.Inactive
                    };
                    _dbContext.SRooms.Update(department);
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
                                 where (string.IsNullOrEmpty(input.NameFilter) || r.Name == input.NameFilter)
                                     && (string.IsNullOrEmpty(input.CodeFilter) || r.Code == input.CodeFilter)
                                     && (input.DepartmentIdFilter == null || r.DepartmentId == input.DepartmentIdFilter)
                                     && (input.InactiveFilter == null || r.Inactive == input.InactiveFilter)
                                 select new SRoomDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Description = r.Description,
                                     DepartmentId = r.DepartmentId,
                                     Inactive = r.Inactive
                                 }).ToList();
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
            var department = _dbContext.SRooms.SingleOrDefault(s => s.Id == id);
            if (department != null)
            {
                result.IsSuccessed = true;
                result.Result = new SRoomDto()
                {
                    Id = department.Id,
                    Code = department.Code,
                    Name = department.Name,
                    Description = department.Description,
                    DepartmentId = department.DepartmentId,
                    Inactive = department.Inactive
                };
            }

            return await Task.FromResult(result);
        }
    }
}
