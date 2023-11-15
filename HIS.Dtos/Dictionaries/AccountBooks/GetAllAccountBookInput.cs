using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries
{
    public class GetAllAccountBookInput : PagedResultRequestDto
    {
        public Guid? UserId { get; set; }
        public Guid? TransactionTypeId { get; set; }
    }
}
