using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.MedicalRecordTypes
{
    public class MedicalRecordTypeDto : EntityDto<int>
    {
        public string MedicalRecordTypeCode { get; set; }
        public string MedicalRecordTypeName { get; set; }
        public string Description { get; set; }
        public int SortOrder { get; set; }
        public bool Inactive { get; set; }
        public int MedicalRecordTypeGroupID { get; set; }
    }
}
