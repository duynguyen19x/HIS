using HIS.ApplicationService.Base;
using HIS.Dtos.Dictionaries.MedicinePricePolicy;
using HIS.EntityFrameworkCore.Entities.Categories.Medicines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.MedicinePricePolicy
{
    public interface ISMedicinePricePolicyService : IBaseDictionaryService<MedicinePricePolicyDto, GetAllMedicinePricePolicyInput, Guid>
    {
         
    }
}
