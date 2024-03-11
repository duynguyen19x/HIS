using HIS.ApplicationService.Systems.User.Dtos;
using HIS.Dtos.Systems.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.Authorization.Dtos
{
    public class LoginResultDto
    {
        public SYSUserDto User { get; set; }

        public TokenResultDto TokenResult { get; set; }
    }
}
