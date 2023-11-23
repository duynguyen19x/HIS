using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.RelativeCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.RelativeCategories
{
    public interface IRelativeCategoryAppService : IBaseCrudAppService<RelativeCategoryDto, Guid, GetAllRelativeCategoryInput>
    {
    }
}
