using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.MedicalRecordTypeGroups
{
    public class GetAllMedicalRecordTypeGroupInput : PagedResultRequestDto
    {
        public string MedicalRecordTypeGroupCodeFilter { get; set; }
        public string MedicalRecordTypeGroupNameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
