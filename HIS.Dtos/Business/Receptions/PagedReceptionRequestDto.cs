using HIS.Application.Core.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.Receptions
{
    public class PagedReceptionRequestDto : PagedResultRequestDto
    {
        public virtual Guid? DepartmentId { get; set; }
        public virtual Guid? RoomId { get; set; }
        public virtual DateTime? ReceptionFromDate { get; set; }
        public virtual DateTime? ReceptionToDate { get; set; }
    }
}
