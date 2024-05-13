using AutoMapper;
using HIS.ApplicationService.Dictionary.Departments.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Transactions;

namespace HIS.ApplicationService.Dictionary.Rooms.Dto
{
    internal class RoomAppService : BaseAppService, IRoomAppService
    {
        private readonly IRepository<Room, Guid> _roomRepository;
        private readonly IRepository<RoomType, int> _roomTypeRepository;
        private readonly IRepository<Department, Guid> _departmentRepository;

        public RoomAppService(IRepository<Room, Guid> roomRepository, IRepository<RoomType, int> roomTypeRepository, IRepository<Department, Guid> departmentRepository)
        {
            _roomRepository = roomRepository;
            _roomTypeRepository = roomTypeRepository;
            _departmentRepository = departmentRepository;
        }

        public virtual async Task<PagedResultDto<RoomDto>> GetAllAsync(GetAllRoomInputDto input)
        {
            var result = new PagedResultDto<RoomDto>();
            try
            {
                var filter = _roomRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code == input.CodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name == input.NameFilter)
                    .WhereIf(input.RoomTypeFilter != null, x => x.RoomTypeId == input.RoomTypeFilter)
                    .WhereIf(input.DepartmentFilter != null, x => x.DepartmentId == input.DepartmentFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var query = from o in filter

                            join o1 in _roomTypeRepository.GetAll() on o.RoomTypeId equals o1.Id 
                            into j1 from s1 in j1.DefaultIfEmpty()

                            join o2 in _departmentRepository.GetAll() on o.DepartmentId equals o2.Id 
                            into j2 from s2 in j2.DefaultIfEmpty()

                            select new RoomDto()
                            {
                                Id = o.Id,
                                Code = o.Code,
                                MediCode = o.MediCode,
                                Name = o.Name,
                                RoomTypeId = o.RoomTypeId,
                                RoomTypeCode = s1.Code,
                                RoomTypeName = s1.Name,
                                DepartmentId = o.DepartmentId,
                                DepartmentCode = s2.Code,
                                DepartmentName = s2.Name,
                                Description = o.Description,
                                SortOrder = o.SortOrder,
                                Inactive = o.Inactive
                            };

                var paged = query.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = paged.ToList();
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<RoomDto>> GetAsync(Guid id)
        {
            var result = new ResultDto<RoomDto>();
            try
            {
                var entity = await _roomRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<RoomDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<RoomDto>> CreateOrUpdateAsync(RoomDto input)
        {
            if (Check.IsNullOrDefault(input.Id))
            {
                return await CreateAsync(input);
            }
            else
            {
                return await UpdateAsync(input);
            }
        }

        public virtual async Task<ResultDto<RoomDto>> CreateAsync(RoomDto input)
        {
            var result = new ResultDto<RoomDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var room = ObjectMapper.Map<Room>(input);

                    await _roomRepository.InsertAsync(room);

                    unitOfWork.Complete();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<RoomDto>> UpdateAsync(RoomDto input)
        {
            var result = new ResultDto<RoomDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _roomRepository.GetAsync(input.Id.GetValueOrDefault());

                    ObjectMapper.Map(input, entity);

                    unitOfWork.Complete();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<RoomDto>> DeleteAsync(Guid id)
        {
            var result = new ResultDto<RoomDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var room = _roomRepository.Get(id);

                    await _roomRepository.DeleteAsync(room);

                    unitOfWork.Complete();
                    result.Success(null);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<PagedResultDto<RoomDto>> GetByStocks()
        {
            var result = new PagedResultDto<RoomDto>();
            try
            {
                result.Result = (from r in _roomRepository.GetAll()
                                 join t in _roomTypeRepository.GetAll() on r.RoomTypeId equals t.Id
                                 join d in _departmentRepository.GetAll() on r.DepartmentId equals d.Id
                                 where d.DepartmentTypeId == (int)HIS.Utilities.Enums.DepartmentTypes.PharmacyDepartment
                                 select new RoomDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     MediCode = r.MediCode,
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
