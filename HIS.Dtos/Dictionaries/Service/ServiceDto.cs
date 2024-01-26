using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.ExecutionRoom;
using HIS.Dtos.Dictionaries.ServicePricePolicy;
using HIS.Dtos.Dictionaries.ServiceResultIndex;

namespace HIS.Dtos.Dictionaries.Service
{
    public class ServiceDto : EntityDto<Guid?>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string HeInCode { get; set; }

        public string HeInName { get; set; }

        public int? SortOrder { get; set; }


        public bool Inactive { get; set; }

        public Guid? UnitId { get; set; }
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

        public IList<ServicePricePolicyDto> SServicePricePolicies { get; set; }
        public IList<ExecutionRoomDto> SExecutionRooms { get; set; }
        public IList<ServiceResultIndiceDto> SServiceResultIndices { get; set; }
    }
}
