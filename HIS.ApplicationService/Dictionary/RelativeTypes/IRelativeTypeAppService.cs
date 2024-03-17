using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.RelativeTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.RelativeTypes
{
    public interface IRelativeTypeAppService : IBaseCrudAppService<RelativeTypeDto, Guid, GetAllRelativeTypeInputDto>
    {
    }
}
