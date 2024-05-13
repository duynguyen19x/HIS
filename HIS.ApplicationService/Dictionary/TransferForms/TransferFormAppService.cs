using HIS.ApplicationService.Dictionary.RoomTypes.Dto;
using HIS.ApplicationService.Dictionary.TransferForms.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.TransferForms
{
    public class TransferFormAppService : BaseAppService, ITransferFormAppService
    {
        private readonly IRepository<TransferForm, Guid> _transferFormRepository;

        public TransferFormAppService(IRepository<TransferForm, Guid> transferFormRepository) 
        {
            _transferFormRepository = transferFormRepository;
        }

        public virtual async Task<PagedResultDto<TransferFormDto>> GetAll(GetAllTransferFormInputDto input)
        {
            var result = new PagedResultDto<TransferFormDto>();
            try
            {
                var query = _transferFormRepository.GetAll().WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                if (Check.IsNullOrDefault(input.Sorting))
                    input.Sorting = "SortOrder";

                var paged = query.ApplySortingAndPaging(input);

                result.TotalCount = await query.CountAsync();
                result.Result = ObjectMapper.Map<IList<TransferFormDto>>(paged.ToList());
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }
    }
}
