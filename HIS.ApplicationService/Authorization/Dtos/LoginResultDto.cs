using HIS.ApplicationService.Systems.Users.Dto;
using HIS.Dtos.Systems.Login;

namespace HIS.ApplicationService.Authorization.Dtos
{
    public class LoginResultDto
    {
        public UserDto User { get; set; }

        public TokenResultDto TokenResult { get; set; }
    }
}
