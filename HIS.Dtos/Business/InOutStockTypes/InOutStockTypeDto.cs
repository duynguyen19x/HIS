﻿using HIS.Core.Services.Dto;

namespace HIS.Dtos.Business.InOutStockTypes
{
    public class InOutStockTypeDto : EntityDto<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Inactive { get; set; }
    }
}
