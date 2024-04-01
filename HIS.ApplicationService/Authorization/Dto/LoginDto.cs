using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Authorization.Dto
{
    public class LoginDto : EntityDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
