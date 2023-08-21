namespace HIS.Dtos.Dictionaries.Career
{
    public class GetAllSCareerInput
    {
        public string CodeFilter { get; set; }
        public string NameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
