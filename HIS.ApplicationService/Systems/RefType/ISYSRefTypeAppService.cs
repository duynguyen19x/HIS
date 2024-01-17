using HIS.Application.Core.Services;
using HIS.Dtos.Systems;
using HIS.Dtos.Systems.RefType;

namespace HIS.ApplicationService.Systems.RefType
{
    public interface ISYSRefTypeAppService : HIS.Core.Services.ICrudAppService<SYSRefTypeDto, int, GetAllSYSRefTypeInputDto>
    {
    }
}
