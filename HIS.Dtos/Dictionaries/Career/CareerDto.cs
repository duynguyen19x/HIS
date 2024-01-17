using HIS.Core.Services.Dto;

namespace HIS.Dtos.Dictionaries.Career
{
    public class CareerDto : EntityDto<Guid?>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Inactive { get; set; }
    }
}
