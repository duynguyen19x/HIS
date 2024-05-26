using HIS.ApplicationService.Dictionary.HospitalLevels.Dto;
using HIS.ApplicationService.Dictionary.HospitalLines.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities;
using HIS.EntityFrameworkCore.Entities.Dictionary;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HIS.ApplicationService.Dictionary.HospitalLines
{
    public class HospitalLineAppService : BaseAppService, IHospitalLineAppService
    {
        private readonly IRepository<HospitalLine, Guid> _hospitalLineRepository;

        public HospitalLineAppService(IRepository<HospitalLine, Guid> hospitalLineRepository)
        {
            _hospitalLineRepository = hospitalLineRepository;
        }

        public async Task<PagedResultDto<HospitalLineDto>> GetAll(GetAllHospitalLineInputDto input)
        {
            var result = new PagedResultDto<HospitalLineDto>();
            try
            {
                var filter = _hospitalLineRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.HospitalLineCodeFilter), x => x.HospitalLineCode == input.HospitalLineCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.HospitalLineNameFilter), x => x.HospitalLineName == input.HospitalLineNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<HospitalLineDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async Task<ResultDto<HospitalLineDto>> Get(Guid id)
        {
            var result = new ResultDto<HospitalLineDto>();
            try
            {
                var entity = await _hospitalLineRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<HospitalLineDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async Task<ResultDto<HospitalLineDto>> CreateOrEdit(HospitalLineDto input)
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

        public async Task<ResultDto<HospitalLineDto>> Create(HospitalLineDto input)
        {
            var result = new ResultDto<HospitalLineDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var branch = ObjectMapper.Map<HospitalLine>(input);

                    await _hospitalLineRepository.InsertAsync(branch);

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

        public async Task<ResultDto<HospitalLineDto>> Update(HospitalLineDto input)
        {
            var result = new ResultDto<HospitalLineDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _hospitalLineRepository.GetAsync(input.Id.GetValueOrDefault());

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

        public async Task<ResultDto<HospitalLineDto>> Delete(Guid id)
        {
            var result = new ResultDto<HospitalLineDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _hospitalLineRepository.Get(id);

                    await _hospitalLineRepository.DeleteAsync(entity);

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
