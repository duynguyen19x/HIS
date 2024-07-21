using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.ServicePricePolicies.Dto
{
    public class ServicePricePolicyDto : EntityDto<Guid?>
    {
        public Guid? ServiceId { get; set; }
        public int? PatientTypeId { get; set; }
        public decimal? OldUnitPrice { get; set; }
        public decimal? NewUnitPrice { get; set; }
        public decimal? CeilingPrice { get; set; }
        public decimal? PaymentRate { get; set; }
        public DateTime? ExecutionTime { get; set; }

        public bool IsHeIn { get; set; }
        public string PatientTypeCode { get; set; }
        public string PatientTypeName { get; set; }

        public bool Inactive { get; set; }
    }
}
