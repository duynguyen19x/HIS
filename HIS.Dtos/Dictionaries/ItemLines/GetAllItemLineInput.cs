namespace HIS.Dtos.Dictionaries.ItemLines
{
    public  class GetAllItemLineInput
    {
        public string CodeFilter { get; set; }
        public string NameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
