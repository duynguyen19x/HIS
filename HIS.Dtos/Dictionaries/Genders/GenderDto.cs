using HIS.Core.Services.Dto;

namespace HIS.Dtos.Dictionaries.Genders
{
    public class GenderDto : EntityDto<Guid?>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? SortOrder { get; set; }
        public bool Inactive { get; set; }
    }
}
