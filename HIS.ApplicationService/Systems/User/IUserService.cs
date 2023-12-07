using HIS.Application.Core.Services;
using HIS.Dtos.Systems.User;

namespace HIS.ApplicationService.Systems.User
{
    public interface IUserService : IBaseCrudAppService<UserDto, Guid?, GetAllUserInput>
    {
    }
}
