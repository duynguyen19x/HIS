using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.MedicineType
{
    public class GetAllMedicineTypeInput
    {
        public string CodeFilter { get; set; }
        public string HeInCodeFilter { get; set; }
        public string NameFilter { get; set; }
        public Guid? MedicineLineIdFilter { get; set; }
        public List<Guid?> MedicineLineIdsFilter { get; set; }
        public Guid? MedicineGroupIdFilter { get; set; }
        public List<Guid?> MedicineGroupIdsFilter { get; set; }
        public Guid? UnitIdFilter { get; set; }
        public List<Guid?> UnitIdsFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
