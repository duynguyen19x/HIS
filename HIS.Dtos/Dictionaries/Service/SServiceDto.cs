using HIS.Dtos.Base;
using HIS.Dtos.Dictionaries.ExecutionRoom;
using HIS.Dtos.Dictionaries.ServicePricePolicy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.Service
{
    public class SServiceDto : EntityDto<Guid?>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string HeInCode { get; set; }

        public string HeInName { get; set; }

        public int? SoftOrder { get; set; }

        public bool? Inactive { get; set; }

        //public Guid? ServiceTypeId { get; set; }
        public Guid? ServiceUnitId { get; set; }
        public Guid? ServiceGroupId { get; set; }
        public Guid? ServiceGroupHeInId { get; set; }
        public Guid? SurgicalProcedureTypeId { get; set; }

        public string ServiceUnitCode { get; set; }
        public string ServiceUnitName { get; set; }
        public string ServiceGroupCode { get; set; }
        public string ServiceGroupName { get; set; }

        public string ServiceGroupHeInCode { get; set; }
        public string ServiceGroupHeInName { get; set; }

        public IList<SServicePricePolicyDto> ServicePricePolicies { get; set; } 
        public IList<SExecutionRoomDto> ExecutionRooms { get; set; } 
    }
}
