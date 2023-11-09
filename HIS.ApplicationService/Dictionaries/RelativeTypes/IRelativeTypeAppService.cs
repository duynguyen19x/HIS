using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.RelativeTypes;

namespace HIS.ApplicationService.Dictionaries.RelativeTypes
{
    public interface IRelativeTypeAppService : IBaseCrudAppService<RelativeTypeDto, Guid, PagedRelativeTypeInputDto>
    {
    }
}
