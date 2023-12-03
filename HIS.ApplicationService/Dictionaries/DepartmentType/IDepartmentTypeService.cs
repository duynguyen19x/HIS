using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.DepartmentType;

namespace HIS.ApplicationService.Dictionaries.DepartmentType
{
    public interface IDepartmentTypeService : IBaseCrudAppService<DepartmentTypeDto, int?, GetAllDepartmentTypeInput>
    {
    }
}
