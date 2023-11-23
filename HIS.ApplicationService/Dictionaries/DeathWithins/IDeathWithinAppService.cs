using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.DeathWithins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.DeathWithins
{
    public interface IDeathWithinAppService : IBaseCrudAppService<DeathWithinDto, Guid, GetAllDeathWithinInput>
    {
    }
}
