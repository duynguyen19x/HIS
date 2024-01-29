using HIS.Application.Core.Services;
using HIS.Dtos.Systems.RefTypeCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.RefTypeCategory
{
    public interface ISYSRefTypeCategoryAppService : IBaseCrudAppService<SYSRefTypeCategoryDto, int, GetAllSYSRefTypeCategoryInputDto>
    {
    }
}
