﻿using AutoMapper;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.Icd;
using HIS.Dtos.Dictionaries.ServicePricePolicy;
using HIS.Dtos.Dictionaries.Supplier;
using HIS.EntityFrameworkCore.DbContexts;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Models.Commons;
using HIS.Utilities.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.Supplier
{
    public class SSupplierService : BaseSerivce, ISSupplierService
    {
        public SSupplierService(HIS_DbContext dbContext, IConfiguration config, IMapper mapper) : base(dbContext, config, mapper)
        {

        }

        public async Task<ApiResult<SSupplierDto>> CreateOrEdit(SSupplierDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ApiResult<SSupplierDto>> Create(SSupplierDto input)
        {
            var result = new ApiResult<SSupplierDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var sSupplier = _mapper.Map<SSupplier>(input);
                    _dbContext.SSuppliers.Add(sSupplier);
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

        public async Task<ApiResult<SSupplierDto>> Update(SSupplierDto input)
        {
            var result = new ApiResult<SSupplierDto>();
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var sSupplier = _mapper.Map<SSupplier>(input);
                    _dbContext.SSuppliers.Update(sSupplier);
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

        public async Task<ApiResult<SSupplierDto>> Delete(Guid id)
        {
            var result = new ApiResult<SSupplierDto>();

            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var sSupplier = _dbContext.SSuppliers.SingleOrDefault(x => x.Id == id);
                    if (sSupplier != null)
                    {
                        _dbContext.SSuppliers.Remove(sSupplier);
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

        public async Task<ApiResultList<SSupplierDto>> GetAll(GetAllSSupplierInput input)
        {
            var result = new ApiResultList<SSupplierDto>();

            try
            {
                result.Result = (from r in _dbContext.SSuppliers
                                 select new SSupplierDto()
                                 {
                                     Id = r.Id,
                                     Code = r.Code,
                                     Name = r.Name,
                                     Description = r.Description,
                                     Inactive = r.Inactive,
                                 })
                                 .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), w => w.Code == input.CodeFilter)
                                 .WhereIf(!string.IsNullOrEmpty(input.NameFilter), w => w.Name == input.NameFilter)
                                 .WhereIf(input.InactiveFilter != null, w => w.Inactive == input.InactiveFilter)
                                 .OrderBy(o => o.Code).ToList();

                result.TotalCount = result.Result.Count;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return await Task.FromResult(result);
        }

        public async Task<ApiResult<SSupplierDto>> GetById(Guid id)
        {
            var result = new ApiResult<SSupplierDto>();

            try
            {
                var sSuppliers = _dbContext.SSuppliers.FirstOrDefault(s => s.Id == id);
                if (sSuppliers != null)
                {
                    result.Result = _mapper.Map<SSupplierDto>(sSuppliers);
                }
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