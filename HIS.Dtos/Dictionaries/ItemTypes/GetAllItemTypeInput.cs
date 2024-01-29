using HIS.Core.Services.Dto;

namespace HIS.Dtos.Dictionaries.ItemTypes
{
    public class GetAllItemTypeInput : PagedResultRequestDto
    {
        public string CodeFilter { get; set; }
        public string HeInCodeFilter { get; set; }
        public string NameFilter { get; set; }
        public Guid? ItemLineIdFilter { get; set; }
        public List<Guid?> ItemLineIdsFilter { get; set; }
        public Guid? ItemGroupIdFilter { get; set; }
        public List<Guid?> ItemGroupIdsFilter { get; set; }
        public Guid? UnitIdFilter { get; set; }
        public List<Guid?> UnitIdsFilter { get; set; }
        public bool? InactiveFilter { get; set; }
        public int? CommodityTypeFilter { get; set; }
    }
}
