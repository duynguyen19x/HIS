using HIS.ApplicationService.Dictionary.Branchs.Dto;
using HIS.ApplicationService.Dictionary.HospitalLevels.Dto;
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

namespace HIS.ApplicationService.Dictionary.HospitalLevels
{
    public class HospitalLevelAppService : BaseAppService, IHospitalLevelAppService
    {
        private readonly IRepository<HospitalLevel, Guid> _hospitalLevelRepository;

        public HospitalLevelAppService(IRepository<HospitalLevel, Guid> hospitalLevelRepository)
        {
            _hospitalLevelRepository = hospitalLevelRepository;
        }


        public async Task<PagedResultDto<HospitalLevelDto>> GetAll(GetAllHospitalLevelInputDto input)
        {
            var result = new PagedResultDto<HospitalLevelDto>();
            try
            {
                var filter = _hospitalLevelRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.HospitalLevelCodeFilter), x => x.HospitalLevelCode == input.HospitalLevelCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.HospitalLevelNameFilter), x => x.HospitalLevelName == input.HospitalLevelNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<HospitalLevelDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async Task<ResultDto<HospitalLevelDto>> Get(Guid id)
        {
            var result = new ResultDto<HospitalLevelDto>();
            try
            {
                var entity = await _hospitalLevelRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<HospitalLevelDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async Task<ResultDto<HospitalLevelDto>> CreateOrEdit(HospitalLevelDto input)
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

        public async Task<ResultDto<HospitalLevelDto>> Create(HospitalLevelDto input)
        {
            var result = new ResultDto<HospitalLevelDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var branch = ObjectMapper.Map<HospitalLevel>(input);

                    await _hospitalLevelRepository.InsertAsync(branch);

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

        public async Task<ResultDto<HospitalLevelDto>> Update(HospitalLevelDto input)
        {
            var result = new ResultDto<HospitalLevelDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _hospitalLevelRepository.GetAsync(input.Id.GetValueOrDefault());

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

        public async Task<ResultDto<HospitalLevelDto>> Delete(Guid id)
        {
            var result = new ResultDto<HospitalLevelDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _hospitalLevelRepository.Get(id);

                    await _hospitalLevelRepository.DeleteAsync(entity);

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
