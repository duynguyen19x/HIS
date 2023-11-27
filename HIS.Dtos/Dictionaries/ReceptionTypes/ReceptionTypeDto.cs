﻿using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.ReceptionTypes
{
    public class ReceptionTypeDto : EntityDto<int>
    {
        public string ReceptionTypeCode { get; set; }
        public string ReceptionTypeName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }
    }
}