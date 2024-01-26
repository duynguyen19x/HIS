using HIS.Core.Application.Services.Dto;

namespace HIS.Dtos.Dictionaries.Ethnics
{
    public class EthnicDto : EntityDto<Guid>
    {
        public string EthnicCode { get; set; }
        public string EthnicName { get; set; }
        public string MohCode { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }
    }
}
