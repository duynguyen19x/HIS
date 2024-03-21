using HIS.ApplicationService.System.Permissions.Dto;
using HIS.ApplicationService.Systems.Users.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace HIS.ApplicationService.System.Users
{
    public class UserAppService : BaseAppService, IUserAppService
    {
        private readonly IRepository<Role, Guid> _roleRepository;
        private readonly IRepository<User, Guid> _userRepository;
        private readonly IRepository<Permission, string> _permissionRepository;

        public UserAppService(
            IRepository<User, Guid> userRepository,
            IRepository<Role, Guid> roleRepository,
            IRepository<Permission, string> permissionRepository) 
        {
            _roleRepository = roleRepository;
            _userRepository = userRepository;
            _permissionRepository = permissionRepository;
        }

        public async Task<PagedResultDto<UserDto>> GetAllAsync(GetAllUserInputDto input)
        {
            var result = new PagedResultDto<UserDto>();
            try
            {
                var filter = _userRepository.GetAll();
                var pagedAndSorted = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<UserDto>>(pagedAndSorted.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async Task<ResultDto<UserDto>> GetAsync(Guid id)
        {
            var result = new ResultDto<UserDto>();
            try
            {
                var entity = await _userRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<UserDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async Task<ResultDto<UserDto>> CreateOrUpdateAsync(UserDto input)
        {
            if (Check.IsNullOrDefault(input.Id))
            {
                return await CreateAsync(input);
            }    
            else
            {
                return await UpdateAsync(input);
            }    
        }

        public async Task<ResultDto<UserDto>> CreateAsync(UserDto input) 
        {
            var result = new ResultDto<UserDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var entity = ObjectMapper.Map<User>(input);

                    await _userRepository.InsertAsync(entity);
                    unitOfWork.Complete();

                    result.Result = ObjectMapper.Map<UserDto>(entity);
                    result.IsSucceeded = true;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async Task<ResultDto<UserDto>> UpdateAsync(UserDto input) 
        {
            var result = new ResultDto<UserDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin())
            {
                try
                {
                    var entity = await _userRepository.GetAsync(input.Id.GetValueOrDefault());

                    ObjectMapper.Map(input, entity);
                    unitOfWork.Complete();

                    result.Result = ObjectMapper.Map<UserDto>(entity);
                    result.IsSucceeded = true;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async Task<ResultDto<UserDto>> DeleteAsync(Guid id)
        {
            var result = new ResultDto<UserDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin())
            {
                try
                {
                    var entity = _userRepository.Get(id);
                    await _userRepository.DeleteAsync(entity);

                    unitOfWork.Complete();

                    result.Result = ObjectMapper.Map<UserDto>(entity);
                    result.IsSucceeded = true;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        
    }
}
