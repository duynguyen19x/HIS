using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.Ethnics.Dto
{
    public class EthnicDto : EntityDto<Guid?>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public string MediCode { get; set; }

        public string Description { get; set; }

        public int SortOrder { get; set; }

        public bool Inactive { get; set; }
    }
}
