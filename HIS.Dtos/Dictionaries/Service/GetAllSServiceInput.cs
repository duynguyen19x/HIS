﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.Service
{
    public class GetAllSServiceInput
    {
        public string CodeFilter { get; set; }
        public string NameFilter { get; set; }
        public bool? IsActiveFilter { get; set; }
    }
}