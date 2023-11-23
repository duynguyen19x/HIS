using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.Relatives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.Relatives
{
    public interface IRelativeAppService : IBaseCrudAppService<RelativeDto, Guid, GetAllRelativeInput>
    {
    }
}
