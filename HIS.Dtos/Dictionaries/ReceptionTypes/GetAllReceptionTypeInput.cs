using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.ReceptionTypes
{
    public class GetAllReceptionTypeInput : PagedResultRequestDto
    {
        public string ReceptionTypeCodeFilter { get; set; }
        public string ReceptionTypeNameFilter { get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
