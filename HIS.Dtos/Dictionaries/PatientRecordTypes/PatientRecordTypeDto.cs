using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.PatientRecordTypes
{
    public class PatientRecordTypeDto : EntityDto<int>
    {
        public string PatientRecordTypeCode { get; set; }
        public string PatientRecordTypeName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }

        public PatientRecordTypeDto() { }
    }
}
