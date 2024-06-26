﻿namespace HIS.ApplicationService.Dictionary.Services.Dto
{
    public class ServiceImportExcelDto : ServiceDto
    {
        public decimal HeInPrice { get; set; }
        public decimal ServicePrice { get; set; }
        public decimal PeoplePrice { get; set; }
        public decimal PaymentRate { get; set; }
        public decimal CeilingPrice { get; set; }
        public string ExecutionTimeString { get; set; }
        public string ExecutionRoomCode { get; set; }
    }
}
