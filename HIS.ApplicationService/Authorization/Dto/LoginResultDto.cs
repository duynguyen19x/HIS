using HIS.ApplicationService.Systems.Users.Dto;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Systems.Login;

namespace HIS.ApplicationService.Authorization.Dtos
{
    public class LoginResultDto : EntityDto
    {
        public string TokenType { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public long ExpireDate { get; set; }

        public UserDto User { get; set; }

        public LoginResultDto() 
        {
            User = new UserDto();
        }
    }
}
