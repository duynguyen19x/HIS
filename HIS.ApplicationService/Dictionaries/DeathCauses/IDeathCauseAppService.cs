using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.DeathCauses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.DeathCauses
{
    public interface IDeathCauseAppService : IBaseCrudAppService<DeathCauseDto, Guid, GetAllDeathCauseInput>
    {
    }
}
