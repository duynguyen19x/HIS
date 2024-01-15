using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Systems.RefType
{
    public class GetAllSYSRefTypeInputDto : PagedResultRequestDto
    {
        public string RefTypeNameFilter { get; set; }
        public int? RefTypeCategoryFilter { get; set; }
    }
}
