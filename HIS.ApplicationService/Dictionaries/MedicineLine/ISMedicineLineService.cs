using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.MedicineLine;
using HIS.Dtos.Dictionaries.MedicineType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.MedicineLine
{
    public interface ISMedicineLineService : IBaseDictionaryService<MedicineLineDto, GetAllSMedicineLineInput>
    {
    }
}
