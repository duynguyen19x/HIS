using HIS.Dtos.Base;
using HIS.Dtos.Dictionaries.ExecutionRoom;
using HIS.Dtos.Dictionaries.ServicePricePolicy;
using HIS.Dtos.Dictionaries.ServiceResultIndex;
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

        public int? SortOrder { get; set; }


        public bool Inactive { get; set; }

        public Guid? ServiceUnitId { get; set; }
        public Guid? ServiceGroupId { get; set; }
        public Guid? ServiceGroupHeInId { get; set; }
        public int? SurgicalProcedureTypeId { get; set; }

        public string ServiceUnitCode { get; set; }
        public string ServiceUnitName { get; set; }
        public string ServiceGroupCode { get; set; }
        public string ServiceGroupName { get; set; }

        public string ServiceGroupHeInCode { get; set; }
        public string ServiceGroupHeInName { get; set; }
        public string SurgicalProcedureTypeCode { get; set; }

        public IList<SServicePricePolicyDto> SServicePricePolicies { get; set; }
        public IList<SExecutionRoomDto> SExecutionRooms { get; set; }
        public IList<SServiceResultIndiceDto> SServiceResultIndices { get; set; }
    }
}
