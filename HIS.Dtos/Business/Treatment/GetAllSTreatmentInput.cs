using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.Treatment
{
    public class GetAllSTreatmentInput
    {
        public string PatientCodeFilter { get; set; }
        public string PatientNameFilter { get; set; }
        public string CodeFilter { get; set; }
        public DateTime? MaxInTimeClinicalFilter { get; set; } // thời gian đến khám
        public DateTime? MinInTimeClinicalFilter { get; set; } // thời gian đến khám
        public DateTime? MaxInTimeFilter { get; set; } // thời gian vào viện
        public DateTime? MinInTimeFilter { get; set; } // thời gian vào viện
        public DateTime? MaxOutTimeFilter { get; set; } // thời gian ra viện
        public DateTime? MinOutTimeFilter { get; set; } // thời gian ra viện

        public int? Skip { get; set; }
        public int? Take { get; set; }
        public string Sorting { get; set; }
    }
}
