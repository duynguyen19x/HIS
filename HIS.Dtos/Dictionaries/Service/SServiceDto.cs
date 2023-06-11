﻿using HIS.Dtos.Base;
using HIS.Dtos.Dictionaries.ServicePricePolicy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.Service
{
    public class SServiceDto : EntityDto<Guid?>
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public int? SoftOrder { get; set; }

        public bool? Inactive { get; set; }

        public Guid? ServiceTypeId { get; set; }
        public Guid? ServiceUnitId { get; set; }
        public Guid? ServiceGroupId { get; set; }
        public Guid? SurgicalProcedureTypeId { get; set; }

        public IList<SServicePricePolicyDto> SServicePricePolicies { get; set; } 
    }
}
