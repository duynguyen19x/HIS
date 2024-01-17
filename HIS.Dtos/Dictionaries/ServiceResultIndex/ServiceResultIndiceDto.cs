using HIS.Core.Services.Dto;

namespace HIS.Dtos.Dictionaries.ServiceResultIndex
{
    public class ServiceResultIndiceDto : EntityDto<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public decimal? MaleFrom { get; set; }
        public decimal? MaleTo { get; set; }
        public decimal? FemaleFrom { get; set; }
        public decimal? FemaleTo { get; set; }
        public Guid? ServiceId { get; set; }
        public int? SortOrder { get; set; }
        public bool Inactive { get; set; }
        public string Normal { get; set; }

        public string ServiceCode { get; set; }
    }
}
