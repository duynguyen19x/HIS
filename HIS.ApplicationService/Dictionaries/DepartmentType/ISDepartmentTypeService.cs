using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.Department;
using HIS.Dtos.Dictionaries.DepartmentType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.DepartmentType
{
    public interface ISDepartmentTypeService : IBaseDictionaryService<SDepartmentTypeDto, GetAllSDepartmentTypeInput>
    {
    }
}
