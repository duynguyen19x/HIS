using HIS.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;
using HIS.ApplicationService.Dictionary.Rooms.Dto;
using HIS.ApplicationService.Dictionary.RoomTypes.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Domain.Repositories;
using HIS.EntityFrameworkCore.Entities.Dictionary;
using HIS.ApplicationService.Dictionary.DepartmentTypes.Dto;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Transactions;

namespace HIS.ApplicationService.Dictionary.RoomTypes
{
    public class RoomTypeAppService : BaseAppService, IRoomTypeAppService
    {
        private readonly IRepository<RoomType, int> _roomTypeRepository;

        public RoomTypeAppService(IRepository<RoomType, int> roomTypeRepository)
        {
            _roomTypeRepository = roomTypeRepository;
        }

        public virtual async Task<PagedResultDto<RoomTypeDto>> GetAllAsync(GetAllRoomTypeInputDto input)
        {
            var result = new PagedResultDto<RoomTypeDto>();
            try
            {
                var query = _roomTypeRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code == input.CodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name == input.NameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = query.ApplySortingAndPaging(input);

                result.TotalCount = await query.CountAsync();
                result.Result = ObjectMapper.Map<IList<RoomTypeDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<RoomTypeDto>> GetAsync(int id)
        {
            var result = new ResultDto<RoomTypeDto>();
            try
            {
                var entity = await _roomTypeRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<RoomTypeDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<RoomTypeDto>> CreateOrUpdateAsync(RoomTypeDto input)
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

        public virtual async Task<ResultDto<RoomTypeDto>> CreateAsync(RoomTypeDto input)
        {
            var result = new ResultDto<RoomTypeDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    //input.Id = Guid.NewGuid();
                    var roomType = ObjectMapper.Map<RoomType>(input);

                    await _roomTypeRepository.InsertAsync(roomType);

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

        public virtual async Task<ResultDto<RoomTypeDto>> UpdateAsync(RoomTypeDto input)
        {
            var result = new ResultDto<RoomTypeDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _roomTypeRepository.GetAsync(input.Id);

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

        public virtual async Task<ResultDto<RoomTypeDto>> DeleteAsync(int id)
        {
            var result = new ResultDto<RoomTypeDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _roomTypeRepository.Get(id);

                    await _roomTypeRepository.DeleteAsync(entity);

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

    }
}
