using HIS.Core.Application.Services;
using HIS.Core.Domain.Repositories;
using HIS.EntityFrameworkCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Orders
{
    public class OrderAppService : BaseAppService, IOrderAppService
    {
        private readonly IRepository<Order, Guid> _orderRepository; 

        public OrderAppService(
            IRepository<Order, Guid> orderRepository) 
        {
            _orderRepository = orderRepository;
        }
    }
}
