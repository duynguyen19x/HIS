using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.MedicineGroup;
using HIS.Dtos.Dictionaries.MedicineType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.MedicineType
{
    public interface ISMedicineTypeService : IBaseDictionaryService<SMedicineTypeDto, GetAllSMedicineTypeInput>
    {
    }
}
