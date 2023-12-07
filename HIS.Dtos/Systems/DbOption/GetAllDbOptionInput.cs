using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Systems.DbOption
{
    public class GetAllDbOptionInput : PagedResultRequestDto
    {
        public string DbOptionIdFilter { get; set; }
    }
}
