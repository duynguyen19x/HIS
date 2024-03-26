namespace HIS.Dtos.Dictionaries.Items
{
    public class GetAllItemeInput
    {
        public string CodeFilter { get; set; }
        public string HeInCodeFilter { get; set; }
        public string NameFilter { get; set; }
        public Guid? ItemLineIdFilter { get; set; }
        public Guid? ItemLineIdsFilter { get; set; }
        public Guid? ItemGroupIdFilter { get; set; }
        public Guid? ItemGroupIdsFilter { get; set; }
        public Guid? UnitIdFilter { get; set; }
        public Guid? UnitIdsFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
