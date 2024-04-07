using HIS.ApplicationService.Dictionary.LiveAreas.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.Dtos.Dictionaries.Ward;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.Dictionary;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HIS.ApplicationService.Dictionary.LiveAreas
{
    public class LiveAreaAppService : BaseAppService, ILiveAreaAppService
    {
        private readonly IRepository<LiveArea, Guid> _liveAreaRepository;

        public LiveAreaAppService(IRepository<LiveArea, Guid> liveAreaRepository) 
        {
            _liveAreaRepository = liveAreaRepository;
        }

        public virtual async Task<PagedResultDto<LiveAreaDto>> GetAll(GetAllLiveAreaInputDto input)
        {
            var result = new PagedResultDto<LiveAreaDto>();
            try
            {
                var filter = _liveAreaRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code == input.CodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name == input.NameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                if (Check.IsNullOrDefault(input.Sorting))
                    input.Sorting = "SortOrder";

                var paged = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<LiveAreaDto>>(paged.ToList());
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return result;
        }

        public virtual async Task<ResultDto<LiveAreaDto>> GetById(Guid id)
        {
            var result = new ResultDto<LiveAreaDto>();
            try
            {
                var entity = await _liveAreaRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<LiveAreaDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<LiveAreaDto>> CreateOrEdit(LiveAreaDto input)
        {
            if (Check.IsNullOrDefault(input.Id))
            {
                return await Create(input);
            }
            else
            {
                return await Update(input);
            }
        }

        public virtual async Task<ResultDto<LiveAreaDto>> Create(LiveAreaDto input)
        {
            var result = new ResultDto<LiveAreaDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var entity = ObjectMapper.Map<LiveArea>(input);

                    await _liveAreaRepository.InsertAsync(entity);

                    await unitOfWork.CompleteAsync();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<LiveAreaDto>> Update(LiveAreaDto input)
        {
            var result = new ResultDto<LiveAreaDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _liveAreaRepository.GetAsync(input.Id.GetValueOrDefault());

                    ObjectMapper.Map(input, entity);

                    await unitOfWork.CompleteAsync();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<LiveAreaDto>> Delete(Guid id)
        {
            var result = new ResultDto<LiveAreaDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _liveAreaRepository.Get(id);
                    await _liveAreaRepository.DeleteAsync(entity);

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
