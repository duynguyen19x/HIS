using HIS.ApplicationService.Dictionary.InvoiceGroups.Dto;
using HIS.ApplicationService.Dictionary.RelativeTypes.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities.Dictionary;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HIS.ApplicationService.Dictionary.InvoiceGroups
{
    public class InvoiceGroupAppService : BaseAppService, IInvoiceGroupAppService
    {
        private readonly IRepository<InvoiceGroup, Guid> _invoiceGroupRepository;

        public InvoiceGroupAppService(IRepository<InvoiceGroup, Guid> invoiceGroupRepository) 
        {
            _invoiceGroupRepository = invoiceGroupRepository;
        }

        public virtual async Task<PagedResultDto<InvoiceGroupDto>> GetAll(GetAllInvoiceGroupInputDto input)
        {
            var result = new PagedResultDto<InvoiceGroupDto>();
            try
            {
                var filter = _invoiceGroupRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code == input.CodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name == input.NameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter)
                    .WhereIf(Check.IsNotNullAndDefault(input.UserFilter), x => x.UserId == input.UserFilter);

                var paged = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<InvoiceGroupDto>>(paged.ToList());
                
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<InvoiceGroupDto>> GetById(Guid id)
        {
            var result = new ResultDto<InvoiceGroupDto>();
            try
            {
                var data = await _invoiceGroupRepository.GetAsync(id);
                result.Result = ObjectMapper.Map<InvoiceGroupDto>(data);
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<InvoiceGroupDto>> CreateOrEdit(InvoiceGroupDto input)
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

        public virtual async Task<ResultDto<InvoiceGroupDto>> Create(InvoiceGroupDto input)
        {
            var result = new ResultDto<InvoiceGroupDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var entity = ObjectMapper.Map<InvoiceGroup>(input);

                    await _invoiceGroupRepository.InsertAsync(entity);

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

        public virtual async Task<ResultDto<InvoiceGroupDto>> Update(InvoiceGroupDto input)
        {
            var result = new ResultDto<InvoiceGroupDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _invoiceGroupRepository.GetAsync(input.Id.GetValueOrDefault());

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

        public virtual async Task<ResultDto<InvoiceGroupDto>> Delete(Guid id)
        {
            var result = new ResultDto<InvoiceGroupDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _invoiceGroupRepository.Get(id);
                    await _invoiceGroupRepository.DeleteAsync(entity);

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
