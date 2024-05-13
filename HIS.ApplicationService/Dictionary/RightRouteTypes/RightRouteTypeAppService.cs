using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;
using HIS.Core.Domain.Repositories;
using HIS.Core.Application.Services;
using HIS.ApplicationService.Dictionary.RightRouteTypes.Dto;

namespace HIS.ApplicationService.Dictionaries.RightRouteTypes
{
    public class RightRouteTypeAppService : BaseAppService, IRightRouteTypeAppService
    {
        private readonly IRepository<RightRouteType, int> _rightRouteTypeRepository;

        public RightRouteTypeAppService(IRepository<RightRouteType, int> rightRouteTypeRepository)
        {
            _rightRouteTypeRepository = rightRouteTypeRepository;
        }

        public virtual async Task<PagedResultDto<RightRouteTypeDto>> GetAll(GetAllRightRouteTypeInputDto input)
        {
            var result = new PagedResultDto<RightRouteTypeDto>();
            try
            {
                var filter = _rightRouteTypeRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code == input.CodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name == input.NameFilter);

                if (Check.IsNullOrDefault(input.Sorting))
                    input.Sorting = "SortOrder";

                var paged = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<RightRouteTypeDto>>(paged.ToList());
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
