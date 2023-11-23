using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.TreatmentEndTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.TreatmentEndTypes
{
    public interface ITreatmentEndTypeAppService : IBaseCrudAppService<TreatmentEndTypeDto, int, GetAllTreatmentEndTypeInput>
    {
    }
}
