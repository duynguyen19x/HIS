using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries.TreatmentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.TreatmentResults
{
    public interface ITreatmentResultAppService : IBaseCrudAppService<TreatmentResultDto, int, GetAllTreatmentResultInput>
    {
    }
}
