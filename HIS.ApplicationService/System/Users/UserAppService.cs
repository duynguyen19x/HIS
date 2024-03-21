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
        private readonly IRepository<User, Guid> _sysUserRepository;
        private readonly IRepository<Role, Guid> _sysRoleRepository;

        public UserAppService(
            IRepository<User, Guid> sysUserRepository,
            IRepository<Role, Guid> sysRoleRepository) 
        {
            _sysRoleRepository = sysRoleRepository;
            _sysUserRepository = sysUserRepository;
        }

        public async Task<PagedResultDto<UserDto>> GetAllAsync(GetAllUserInputDto input)
        {
            var result = new PagedResultDto<UserDto>();
            try
            {
                var filter = _sysUserRepository.GetAll();
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
                var entity = await _sysUserRepository.GetAsync(id);

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

                    await _sysUserRepository.InsertAsync(entity);
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
                    var entity = await _sysUserRepository.GetAsync(input.Id.GetValueOrDefault());

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
                    var entity = _sysUserRepository.Get(id);
                    await _sysUserRepository.DeleteAsync(entity);

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
