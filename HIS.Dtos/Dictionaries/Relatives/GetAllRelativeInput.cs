using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.Relatives
{
    public class GetAllRelativeInput : PagedResultRequestDto
    {
        public string RelativeCodeFilter { get; set; }
        public string RelativeNameFilter { get; set; }
    }
}
