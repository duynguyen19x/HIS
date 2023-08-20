using HIS.Application.Core.Services.Dto;

namespace HIS.Dtos.Dictionaries.Career
{
    public class SCareerDto : EntityDto<Guid?>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
    }
}
