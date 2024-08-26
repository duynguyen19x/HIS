using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.Genders.Dto
{
    public class GenderDto : EntityDto<int?>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }
    }
}
