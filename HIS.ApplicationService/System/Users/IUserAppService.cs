using HIS.ApplicationService.System.Users.Dto;
using HIS.ApplicationService.Systems.Users.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.System.Users
{
    public interface IUserAppService : IAppService
    {
        Task<PagedResultDto<UserDto>> GetAllAsync(GetAllUserInputDto input);

        Task<ResultDto<UserDto>> GetAsync(Guid id);

        Task<ResultDto<UserDto>> CreateOrUpdateAsync(UserDto input);

        Task<ResultDto<UserDto>> DeleteAsync(Guid id);


        Task DeActivate(EntityDto<long> user);

        Task Activate(EntityDto<long> user);

        Task<bool> ChangePassword(ChangePasswordDto input);

    }
}
