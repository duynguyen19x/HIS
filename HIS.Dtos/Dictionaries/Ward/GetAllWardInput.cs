using HIS.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.Ward
{
    public class GetAllWardInput : PagedResultRequestDto
    {
        public string WardCodeFilter { get; set; }
        public string WardNameFilter { get; set; }
        public string ShortTextFilter { get; set; }
        public Guid? DistrictFilter {  get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
