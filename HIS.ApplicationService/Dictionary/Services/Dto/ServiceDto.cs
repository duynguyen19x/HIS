using HIS.ApplicationService.Dictionary.ServicePricePolicies.Dto;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.ExecutionRoom;
using HIS.Dtos.Dictionaries.ServiceResultIndex;

namespace HIS.ApplicationService.Dictionary.Services.Dto
{
    public class ServiceDto : EntityDto<Guid?>
    {
        IList<ServicePricePolicyDto> _sServicePricePolicies;
        IList<ExecutionRoomDto> _sExecutionRooms;
        IList<ServiceResultIndiceDto> _sServiceResultIndices;

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

        public IList<ServicePricePolicyDto> SServicePricePolicies
        {
            get
            {
                if (_sServicePricePolicies == null)
                    _sServicePricePolicies = new List<ServicePricePolicyDto>();
                return _sServicePricePolicies;
            }
            set => _sServicePricePolicies = value;
        }
        public IList<ExecutionRoomDto> SExecutionRooms
        {
            get
            {
                if (_sExecutionRooms == null)
                    _sExecutionRooms = new List<ExecutionRoomDto>();
                return _sExecutionRooms;
            }
            set => _sExecutionRooms = value;
        }
        public IList<ServiceResultIndiceDto> SServiceResultIndices
        {
            get
            {
                if (_sServiceResultIndices == null)
                    _sServiceResultIndices = new List<ServiceResultIndiceDto>();
                return _sServiceResultIndices;
            }
            set => _sServiceResultIndices = value;
        }
    }
}
