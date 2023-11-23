using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.ReceptionObjectTypes
{
    public class GetAllReceptionObjectTypeInput : PagedResultRequestDto
    {
        public string ReceptionObjectTypeCodeFilter { get; set; }
        public string ReceptionObjectTypeNameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
