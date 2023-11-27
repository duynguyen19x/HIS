﻿using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.RelativeCategories
{
    public class RelativeCategoryDto : EntityDto<Guid>
    {
        public string RelativeCategoryCode { get; set; }
        public string RelativeCategoryName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public RelativeCategoryDto() { }
    }
}