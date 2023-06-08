using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.ServicePricePolicy;
using HIS.Dtos.Dictionaries.SurgicalProcedureType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.SurgicalProcedureType
{
    public interface ISurgicalProcedureTypeService : IBaseDictionaryService<SSurgicalProcedureTypeDto, GetAllSSurgicalProcedureTypeInput>
    {
    }
}
