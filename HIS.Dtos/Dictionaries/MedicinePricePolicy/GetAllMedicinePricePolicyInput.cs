using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.MedicinePricePolicy
{
    public class GetAllMedicinePricePolicyInput
    {
        public Guid? MedicineIdFilter { get; set; }
        public int? PatientTypeIdFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
