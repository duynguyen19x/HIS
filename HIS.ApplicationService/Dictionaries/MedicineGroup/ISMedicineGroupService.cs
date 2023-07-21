using HIS.ApplicationService.Base;
using HIS.Dtos.Commons;
using HIS.Dtos.Dictionaries.MedicineGroup;
using HIS.Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.MedicineGroup
{
    public interface ISMedicineGroupService : IBaseDictionaryService<SMedicineGroupDto, GetAllSMedicineGroupInput>
    {
        
    }
}
