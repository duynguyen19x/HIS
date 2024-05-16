using HIS.ApplicationService.Business.ServiceRequests.Dto;
using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Orders.Dto
{
    public class OrderDto : EntityDto<Guid>
    {
        public string OrderCode { get; set; }
        public DateTime OrderDate { get; set; }


        public IList<ServiceRequestDto> ServiceRequests { get; set; }

        public OrderDto() 
        { 
            ServiceRequests = new List<ServiceRequestDto>();
        }
    }
}
