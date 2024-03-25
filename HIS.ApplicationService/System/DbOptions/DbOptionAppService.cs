using AutoMapper;
using HIS.ApplicationService.Dictionary.DepartmentTypes.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.Dtos.Systems.DbOption;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionary;
using HIS.EntityFrameworkCore.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Transactions;

namespace HIS.ApplicationService.Systems.DbOptions
{
    public class DbOptionAppService : BaseAppService, IDbOptionAppService
    {
        private readonly IBulkRepository<DbOption, Guid> _dbOptionRepository;

        public DbOptionAppService(IBulkRepository<DbOption, Guid> dbOptionRepository) 
        {
            _dbOptionRepository = dbOptionRepository;
        }

        public virtual async Task<ResultDto<DbOptionDto>> CreateOrEdit(DbOptionDto input)
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

        public virtual async Task<ResultDto<DbOptionDto>> Create(DbOptionDto input)
        {
            var result = new ResultDto<DbOptionDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();

                    var data = ObjectMapper.Map<DbOption>(input);
                    await _dbOptionRepository.InsertAsync(data);

                    var dataParent = await _dbOptionRepository.FirstOrDefaultAsync(w => w.Id == input.ParentId);
                    if (dataParent != null) 
                    {
                        dataParent.IsParent = true;
                        await _dbOptionRepository.UpdateAsync(dataParent);
                    }

                    unitOfWork.Complete();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<DbOptionDto>> Update(DbOptionDto input)
        {
            var result = new ResultDto<DbOptionDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var sServiceDbOption = await _dbOptionRepository.FirstOrDefaultAsync(x => x.Id == input.Id);
                    if (sServiceDbOption != null)
                    {
                        if (sServiceDbOption.ParentId != input.ParentId && !_dbOptionRepository.GetAll().Any(a => a.Id == sServiceDbOption.ParentId))
                        {
                            var dataOldParent = _dbOptionRepository.FirstOrDefault(w => w.Id == sServiceDbOption.ParentId);
                            if (dataOldParent != null) 
                            { 
                                dataOldParent.IsParent = false; 
                            }
                            _dbOptionRepository.Update(dataOldParent);
                        }
                        ObjectMapper.Map(input, sServiceDbOption);
                    }

                    var dataParent = _dbOptionRepository.FirstOrDefault(w => w.Id == input.ParentId);
                    if (dataParent != null) 
                    { 
                        dataParent.IsParent = true; 
                    }
                    _dbOptionRepository.Update(dataParent);

                    unitOfWork.Complete();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<DbOptionDto>> Delete(Guid id)
        {
            var result = new ResultDto<DbOptionDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var sServiceDbOption10 = await _dbOptionRepository.GetAsync(id);
                    if (sServiceDbOption10 != null)
                    {
                        await _dbOptionRepository.DeleteAsync(sServiceDbOption10);
                        unitOfWork.Complete();
                        result.Success(null);
                    }
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }

            return await Task.FromResult(result);
        }

        public virtual async Task<PagedResultDto<DbOptionDto>> GetAll(GetAllDbOptionInput input)
        {
            var result = new PagedResultDto<DbOptionDto>();

            try
            {
                result.Result = (from r in _dbOptionRepository.GetAll()
                                 select new DbOptionDto()
                                 {
                                     Id = r.Id,
                                     DbOptionId = r.DbOptionId,
                                     DbOptionValue = r.DbOptionValue,
                                     DbOptionType = r.DbOptionType,
                                     Description = r.Description,
                                     ParentId = r.ParentId,
                                     IsParent = r.IsParent,
                                 }).OrderBy(o => o.DbOptionId).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return await Task.FromResult(result);
        }

        public virtual async Task<ResultDto<DbOptionDto>> GetById(Guid id)
        {
            var result = new ResultDto<DbOptionDto>();

            try
            {
                var service = await _dbOptionRepository.GetAsync(id);
                result.Result = ObjectMapper.Map<DbOptionDto>(service);
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return result;
        }

        public async Task<ResultDto<OptionValueDto>> GetMapOptions()
        {
            var result = new ResultDto<OptionValueDto>();
            var properties = result.GetType().GetProperties();
            foreach (var property in properties)
            {
                //switch (property.PropertyType)
                //{
                //    case:
                //        break;
                //    default:
                //        break;
                //}
            }

            return await Task.FromResult(result);
        }
    }
}
