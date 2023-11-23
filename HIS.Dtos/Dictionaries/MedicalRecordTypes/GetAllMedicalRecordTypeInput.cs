using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.MedicalRecordTypes
{
    public class GetAllMedicalRecordTypeInput : PagedResultRequestDto
    {
        public string MedicalRecordTypeCodeFilter { get; set; }
        public string MedicalRecordTypeNameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
        public int? MedicalRecordTypeGroupFilter { get; set; }
    }
}
