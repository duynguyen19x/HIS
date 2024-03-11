using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.User.Dtos
{
    public class SYSUserDto : EntityDto<Guid?>
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Mobile { get; set; }
        public string Description { get; set; }
        public Guid? EmployeeId { get; set; }
        public bool Inactive { get; set; }
    }
}
