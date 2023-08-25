namespace HIS.Dtos.Dictionaries.Career
{
    public class GetAllCareerInput
    {
        public string CodeFilter { get; set; }
        public string NameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
