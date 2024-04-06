using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.Ward
{
    public class GetAllWardInput : PagedAndSortedResultRequestDto
    {
        public string CodeFilter { get; set; }
        public string NameFilter { get; set; }
        public string SearchCodeFilter { get; set; }
        public Guid? DistrictFilter {  get; set; }
        public bool? InactiveFilter { get; set; }
    }
}
