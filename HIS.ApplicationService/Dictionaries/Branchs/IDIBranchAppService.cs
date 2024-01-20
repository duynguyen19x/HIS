using HIS.Application.Core.Services;
using HIS.Core.Services;
using HIS.Dtos.Dictionaries.Branchs;

namespace HIS.ApplicationService.Dictionaries.Branchs
{
    public interface IDIBranchAppService : IAsyncCrudAppService<BranchDto, Guid, GetAllBranchInput>
    {

    }
}
