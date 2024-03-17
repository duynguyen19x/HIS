using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.RightRouteTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.RightRouteTypes
{
    public interface IRightRouteTypeAppService : IBaseCrudAppService<RightRouteTypeDto, int, GetAllRightRouteTypeInputDto>
    {
    }
}
