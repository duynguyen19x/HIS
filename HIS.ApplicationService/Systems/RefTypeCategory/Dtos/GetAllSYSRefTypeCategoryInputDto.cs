using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Systems.RefTypeCategory
{
    public class GetAllSYSRefTypeCategoryInputDto : PagedAndSortedResultRequestDto
    {
        public string RefTypeCategoryNameFilter { get; set; }
    }
}
