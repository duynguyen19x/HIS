using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.Service
{
    public class SServiceImportExcelDto : SServiceDto
    {
        public decimal HeInPrice { get; set; }
        public decimal ServicePrice { get; set; }
        public decimal PeoplePrice { get; set; }
        public decimal PaymentRate { get; set; }
        public decimal CeilingPrice { get; set; }
        public DateTime? ExecutionTime { get; set; }
        public string ExecutionRoomCode { get; set; }
    }
}
