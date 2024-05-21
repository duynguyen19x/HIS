using HIS.ApplicationService.Dictionary.TransferReasons.Dto;
using HIS.ApplicationService.Dictionary.TreatmentResultTypes.Dto;
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

namespace HIS.ApplicationService.Dictionary.TreatmentResultTypes
{
    public class TreatmentResultTypeAppService : BaseAppService, ITreatmentResultTypeAppService
    {
        private readonly IRepository<TreatmentResult, int> _treatmentResultTypeRepository;

        public TreatmentResultTypeAppService(IRepository<TreatmentResult, int> treatmentResultTypeRepository)
        {
            _treatmentResultTypeRepository = treatmentResultTypeRepository;
        }

        public virtual async Task<PagedResultDto<TreatmentResultTypeDto>> GetAll(GetAllTreatmentResultTypeInputDto input)
        {
            var result = new PagedResultDto<TreatmentResultTypeDto>();
            try
            {
                var query = _treatmentResultTypeRepository.GetAll().WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                if (Check.IsNullOrDefault(input.Sorting))
                    input.Sorting = "SortOrder";

                var paged = query.ApplySortingAndPaging(input);

                result.TotalCount = await query.CountAsync();
                result.Result = ObjectMapper.Map<IList<TreatmentResultTypeDto>>(paged.ToList());
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }
    }
}
