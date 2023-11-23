using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.PatientObjectTypes
{
    public class PatientObjectTypeDto : EntityDto<int>
    {
        public string PatientObjectTypeCode { get; set; }
        public string PatientObjectTypeName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }
    }
}
