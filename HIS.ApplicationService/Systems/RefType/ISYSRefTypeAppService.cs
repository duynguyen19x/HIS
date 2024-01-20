using HIS.Core.Services;
using HIS.Dtos.Systems;
using HIS.Dtos.Systems.RefType;

namespace HIS.ApplicationService.Systems.RefType
{
    public interface ISYSRefTypeAppService : IAsyncCrudAppService<SYSRefTypeDto, int, GetAllSYSRefTypeInputDto>
    {
    }
}
