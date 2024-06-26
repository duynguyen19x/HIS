﻿using HIS.Core.Application.Services.Dto;

namespace HIS.Dtos.Dictionaries.ItemPricePolicies
{
    public class ItemPricePolicyDto : EntityDto<Guid?>
    {
        public int? PatientTypeId { get; set; }

        /// <summary>
        /// Giá cữ
        /// </summary>
        public decimal? OldUnitPrice { get; set; }

        /// <summary>
        /// Giá mới
        /// </summary>
        public decimal? NewUnitPrice { get; set; }

        /// <summary>
        /// Trần BH
        /// </summary>
        public decimal? CeilingPrice { get; set; }

        /// <summary>
        /// Tỷ lệ thanh toán
        /// </summary>
        public decimal? PaymentRate { get; set; }

        /// <summary>
        /// Ngày áp dụng giá mới
        /// </summary>
        public DateTime? ExecutionTime { get; set; }
        public string ExecutionTimeServer { get; set; }

        /// <summary>
        /// Thuốc
        /// </summary>
        public Guid? ItemId { get; set; }

        public bool IsHeIn { get; set; }
        public string PatientTypeCode { get; set; }
        public string PatientTypeName { get; set; }

        public bool Inactive { get; set; }
    }
}
