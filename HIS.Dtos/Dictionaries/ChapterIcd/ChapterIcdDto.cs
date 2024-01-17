using HIS.Application.Core.Services.Dto;

namespace HIS.Dtos.Dictionaries.ChapterICD10
{
    public  class ChapterIcdDto : EntityDto<Guid?>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public int? SortOrder { get; set; }

        public bool Inactive { get; set; }
    }
}
