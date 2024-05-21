using HIS.ApplicationService.Dictionary.TransferForms.Dto;
using HIS.ApplicationService.Dictionary.TransferReasons.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.TransferReasons
{
    public class TransferReasonAppService : BaseAppService, ITransferReasonAppService
    {
        private readonly IRepository<TransferReason, Guid> _transferReasonRepository;

        public TransferReasonAppService(IRepository<TransferReason, Guid> transferReasonRepository) 
        {
            _transferReasonRepository = transferReasonRepository;
        }

        public virtual async Task<PagedResultDto<TransferReasonDto>> GetAll(GetAllTransferReasonInputDto input)
        {
            var result = new PagedResultDto<TransferReasonDto>();
            try
            {
                var query = _transferReasonRepository.GetAll().WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                if (Check.IsNullOrDefault(input.Sorting))
                    input.Sorting = "SortOrder";

                var paged = query.ApplySortingAndPaging(input);

                result.TotalCount = await query.CountAsync();
                result.Result = ObjectMapper.Map<IList<TransferReasonDto>>(paged.ToList());
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }
    }
}
