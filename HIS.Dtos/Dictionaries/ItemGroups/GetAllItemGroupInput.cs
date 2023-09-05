namespace HIS.Dtos.Dictionaries.ItemGroups
{
    public class GetAllItemGroupInput
    {
        public string CodeFilter { get; set; }
        public string NameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
