using AutoMapper;
using HIS.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;
using HIS.Core.Domain.Repositories;
using HIS.EntityFrameworkCore.Entities;
using HIS.Core.Application.Services;
using HIS.ApplicationService.Dictionary.Suppliers.Dto;
using System.Transactions;
using HIS.ApplicationService.Dictionary.Units.Dto;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Dictionary.Suppliers
{
    public class SupplierAppService : BaseAppService, ISupplierAppService
    {
        private readonly IRepository<Supplier, Guid> _supplierRepository;

        public SupplierAppService(IRepository<Supplier, Guid> supplierRepository) 
        {
            _supplierRepository = supplierRepository;
        }

        public virtual async Task<PagedResultDto<SupplierDto>> GetAll(GetAllSupplierInput input)
        {
            var result = new PagedResultDto<SupplierDto>();
            try
            {
                var filter = _supplierRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), w => w.Code == input.CodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), w => w.Name == input.NameFilter)
                    .WhereIf(input.InactiveFilter != null, w => w.Inactive == input.InactiveFilter);

                var paged = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<SupplierDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<SupplierDto>> GetById(Guid id)
        {
            var result = new ResultDto<SupplierDto>();
            try
            {
                var sSuppliers = await _supplierRepository.FirstOrDefaultAsync(s => s.Id == id);
                if (sSuppliers != null)
                {
                    result.Result = ObjectMapper.Map<SupplierDto>(sSuppliers);
                }
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<SupplierDto>> CreateOrEdit(SupplierDto input)
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

        public virtual async Task<ResultDto<SupplierDto>> Create(SupplierDto input)
        {
            var result = new ResultDto<SupplierDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var entity = ObjectMapper.Map<Supplier>(input);

                    await _supplierRepository.InsertAsync(entity);

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

        public virtual async Task<ResultDto<SupplierDto>> Update(SupplierDto input)
        {
            var result = new ResultDto<SupplierDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _supplierRepository.GetAsync(input.Id.GetValueOrDefault());

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

        public virtual async Task<ResultDto<SupplierDto>> Delete(Guid id)
        {
            var result = new ResultDto<SupplierDto>();

            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _supplierRepository.Get(id);

                    await _supplierRepository.DeleteAsync(entity);

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
