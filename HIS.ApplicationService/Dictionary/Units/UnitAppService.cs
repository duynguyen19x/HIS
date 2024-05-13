using AutoMapper;
using Microsoft.Extensions.Configuration;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;
using HIS.ApplicationService.Dictionary.Units.Dto;
using HIS.Core.Domain.Repositories;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Core.Application.Services;
using HIS.Dtos.Dictionaries.Countries;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace HIS.ApplicationService.Dictionary.Units
{
    public class UnitAppService : BaseAppService, IUnitAppService
    {
        private readonly IRepository<Unit, Guid> _unitRepository;

        public UnitAppService(IRepository<Unit, Guid> unitRepository) 
        {
            _unitRepository = unitRepository;
        }

        public virtual async Task<PagedResultDto<UnitDto>> GetAll(GetAllUnitInput input)
        {
            var result = new PagedResultDto<UnitDto>();

            try
            {
                var filter = _unitRepository.GetAll()
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<UnitDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<UnitDto>> GetById(Guid id)
        {
            var result = new ResultDto<UnitDto>();

            try
            {
                var entity = await _unitRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<UnitDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<UnitDto>> CreateOrEdit(UnitDto input)
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

        public virtual async Task<ResultDto<UnitDto>> Create(UnitDto input)
        {
            var result = new ResultDto<UnitDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var entity = ObjectMapper.Map<Unit>(input);

                    await _unitRepository.InsertAsync(entity);

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

        public virtual async Task<ResultDto<UnitDto>> Update(UnitDto input)
        {
            var result = new ResultDto<UnitDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _unitRepository.GetAsync(input.Id.GetValueOrDefault());

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

        public virtual async Task<ResultDto<UnitDto>> Delete(Guid id)
        {
            var result = new ResultDto<UnitDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _unitRepository.Get(id);

                    await _unitRepository.DeleteAsync(entity);

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
