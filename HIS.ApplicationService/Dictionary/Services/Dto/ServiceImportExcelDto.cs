namespace HIS.ApplicationService.Dictionary.Services.Dto
{
    public class ServiceImportExcelDto : ServiceDto
    {
        public string PatientTypeCode { get; set; }
        public decimal OldUnitPrice { get; set; }
        public decimal NewUnitPrice { get; set; }
        public decimal PaymentRate { get; set; }
        public decimal CeilingPrice { get; set; }
        public DateTime ExecutionTime { get; set; }
        public string ExecutionRoomCode { get; set; }
    }
}
