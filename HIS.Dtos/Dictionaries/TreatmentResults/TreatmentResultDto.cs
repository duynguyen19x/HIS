﻿using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.TreatmentResults
{
    public class TreatmentResultDto : EntityDto<int>
    {
        public string TreatmentResultCode { get; set; }
        public string TreatmentResultName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }
    }
}
