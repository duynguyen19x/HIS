using HIS.ApplicationService.Dictionary.TreatmentEndTypes.Dto;
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

namespace HIS.ApplicationService.Dictionary.TreatmentEndTypes
{
    public class TreatmentEndTypeAppService : BaseAppService, ITreatmentEndTypeAppService
    {
        private readonly IRepository<TreatmentEndType, int> _treatmentEndTypeRepository;

        public TreatmentEndTypeAppService(IRepository<TreatmentEndType, int> treatmentEndTypeRepository) 
        {
            _treatmentEndTypeRepository = treatmentEndTypeRepository;
        }


        public virtual async Task<PagedResultDto<TreatmentEndTypeDto>> GetAll(GetAllTreatmentEndTypeInputDto input)
        {
            var result = new PagedResultDto<TreatmentEndTypeDto>();
            try
            {
                var query = _treatmentEndTypeRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code == input.CodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name == input.NameFilter)
                    .WhereIf(input.IsForInPatientFilter != null, x => x.IsForInPatient == input.IsForInPatientFilter)
                    .WhereIf(input.IsForOutPatientFilter != null, x => x.IsForOutPatient == input.IsForOutPatientFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                if (Check.IsNullOrDefault(input.Sorting))
                    input.Sorting = "SortOrder";

                var paged = query.ApplySortingAndPaging(input);

                result.TotalCount = await query.CountAsync();
                result.Result = ObjectMapper.Map<IList<TreatmentEndTypeDto>>(paged.ToList());
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }
    }
}
