using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.MedicineGroup;
using HIS.Dtos.Dictionaries.MedicineType;
using HIS.Models.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.MedicineType
{
    public interface IMedicineTypeService : IBaseDictionaryService<MedicineTypeDto, GetAllMedicineTypeInput>
    {
        Task<ApiResult<bool>> Import(IList<MedicineTypeDto> input);
    }
}
