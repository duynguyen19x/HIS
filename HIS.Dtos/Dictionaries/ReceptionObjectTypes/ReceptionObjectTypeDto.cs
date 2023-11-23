using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.ReceptionObjectTypes
{
    public class ReceptionObjectTypeDto : EntityDto<int>
    {
        public string ReceptionObjectTypeCode { get; set; }
        public string ReceptionObjectTypeName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }
    }
}
