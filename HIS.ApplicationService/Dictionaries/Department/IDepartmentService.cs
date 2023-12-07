using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.Department;

namespace HIS.ApplicationService.Dictionaries.Department
{
    public interface IDepartmentService : IBaseCrudAppService<DepartmentDto, Guid?, GetAllDepartmentInput>
    {

    }
}
