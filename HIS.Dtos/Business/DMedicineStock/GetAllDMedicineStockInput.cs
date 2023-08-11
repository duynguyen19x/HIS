using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.DMedicineStock
{
    public class GetAllDMedicineStockInput
    {
        public Guid? StockIdFilter { get; set; }
        public Guid? MedicineIdFilter { get; set; }
    }
}
