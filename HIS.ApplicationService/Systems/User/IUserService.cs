using HIS.Dtos.Business.Treatment;
using HIS.Dtos.Systems.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.User
{
    public interface IUserService : IBaseService<SUserDto, GetAllSUserInput>
    {
    }
}
