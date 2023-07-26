using HIS.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.ServicePricePolicy
{
    public class SServicePricePolicyDto : EntityDto<Guid?>
    {
        public Guid? ServiceId { get; set; }
        public Guid? PatientTypeId { get; set; }
        public decimal? OldUnitPrice { get; set; }
        public decimal? NewUnitPrice { get; set; }
        public decimal? CeilingPrice { get; set; }
        public decimal? PaymentRate { get; set; }
        public DateTime? ExecutionTime { get; set; }
        public string ExecutionTimeString { get; set; }

        public bool IsHeIn { get; set; }
        public string PatientTypeCode { get; set; }
        public string PatientTypeName { get; set; }

        public bool Inactive { get; set; }
    }
}
