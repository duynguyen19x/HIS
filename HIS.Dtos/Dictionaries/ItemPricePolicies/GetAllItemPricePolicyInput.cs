﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.ItemPricePolicies
{
    public class GetAllItemPricePolicyInput
    {
        public Guid? ItemIdFilter { get; set; }
        public int? PatientTypeIdFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}