using HIS.ApplicationService.Dictionary.ReceptionObjectTypes.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities.Dictionary;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Dictionary.ReceptionObjectTypes
{
    public class ReceptionObjectTypeAppService : BaseAppService, IReceptionObjectTypeAppService
    {
        private readonly IRepository<ReceptionObjectType, int> _receptionObjectTypeRepository;
        public ReceptionObjectTypeAppService(IRepository<ReceptionObjectType, int> receptionObjectTypeRepository) 
        {
            _receptionObjectTypeRepository = receptionObjectTypeRepository;
        }

        public virtual async Task<PagedResultDto<ReceptionObjectTypeDto>> GetAll(GetAllReceptionObjectTypeInputDto input)
        {
            var result = new PagedResultDto<ReceptionObjectTypeDto>();
            try
            {
                var filter = _receptionObjectTypeRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code == input.CodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name == input.NameFilter);

                if (Check.IsNullOrDefault(input.Sorting))
                    input.Sorting = "SortOrder";

                var paged = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<ReceptionObjectTypeDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }
    }
}
