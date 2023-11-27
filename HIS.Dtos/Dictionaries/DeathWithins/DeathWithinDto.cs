﻿using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.DeathWithins
{
    public class DeathWithinDto : EntityDto<Guid>
    {
        public string DeathWithinCode { get; set; }
        public string DeathWithinName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }
    }
}