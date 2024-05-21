using HIS.ApplicationService.System.Users.Dto;
using HIS.ApplicationService.Systems.Users.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities;
using HIS.EntityFrameworkCore.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Data;

namespace HIS.ApplicationService.System.Users
{
    public class UserAppService : BaseAppService, IUserAppService
    {
        private readonly IBulkRepository<User, Guid> _userRepository;
        private readonly IBulkRepository<Role, Guid> _roleRepository;
        private readonly IBulkRepository<UserRoleMapping, Guid> _userRoleMappingRepository;
        private readonly IBulkRepository<UserRoomMapping, Guid> _userRoomMappingRepository;
        private readonly IBulkRepository<Room, Guid> _roomRepository;

        public UserAppService(
            IBulkRepository<User, Guid> userRepository,
            IBulkRepository<Role, Guid> roleRepository,
            IBulkRepository<UserRoleMapping, Guid> userRoleMappingRepository,
            IBulkRepository<UserRoomMapping, Guid> userRoomMappingRepository,
            IBulkRepository<Room, Guid> roomRepository) 
        {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _userRoleMappingRepository = userRoleMappingRepository;
            _userRoomMappingRepository = userRoomMappingRepository;
            _roomRepository = roomRepository;
        }

        public async Task<PagedResultDto<UserDto>> GetAllAsync(GetAllUserInputDto input)
        {
            var result = new PagedResultDto<UserDto>();
            try
            {
                var filter = _userRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.FullNameFilter), x => x.FullName == input.FullNameFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.FirstNameFilter), x => x.FirstName == input.FirstNameFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.LastNameFilter), x => x.LastName == input.LastNameFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.UsernameFilter), x => x.Username == input.UsernameFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.EmailFilter), x => x.Email == input.EmailFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.TelFilter), x => x.Tel == input.TelFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.MobileFilter), x => x.Mobile == input.MobileFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.DescriptionFilter), x => x.Description == input.DescriptionFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);
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
                var user = await _userRepository.GetAsync(id);
                var userRoleMapping = await _userRoleMappingRepository.GetAllListAsync(x=>x.UserId == user.Id);
                var userRoomMapping = await _userRoomMappingRepository.GetAllListAsync(x=>x.UserId == user.Id);

                var userDto = ObjectMapper.Map<UserDto>(user);
                userDto.Roles = userRoleMapping.Select(s => s.RoleId).ToList();
                userDto.Rooms = userRoomMapping.Select(s => s.RoomId).ToList();
                result.Success(userDto);
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
                    var user = ObjectMapper.Map<User>(input);

                    // vai trò
                    var userRoleMapping = new List<UserRoleMapping>();
                    if (input.Roles != null)
                    {
                        foreach (var role in input.Roles)
                        {
                            userRoleMapping.Add(new UserRoleMapping(user.Id, role));
                        }
                    }

                    // phòng chức năng
                    var userRoomMapping = new List<UserRoomMapping>();
                    if (input.Rooms != null)
                    {
                        foreach (var room in input.Rooms)
                        {
                            userRoomMapping.Add(new UserRoomMapping(user.Id, room));
                        }
                    }    
                    
                    // lưu
                    await _userRepository.InsertAsync(user);
                    if (userRoleMapping.Any())
                        await _userRoleMappingRepository.BulkInsertAsync(userRoleMapping);
                    if (userRoomMapping.Any())
                        await _userRoomMappingRepository.BulkInsertAsync(userRoomMapping);

                    unitOfWork.Complete();
                    result.Success(input);
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
                    var user = await _userRepository.GetAsync(input.Id.GetValueOrDefault());
                    var userRoleMapping = await _userRoleMappingRepository.GetAllListAsync(x => x.UserId == user.Id);
                    var userRoomMapping = await _userRoomMappingRepository.GetAllListAsync(x => x.UserId == user.Id);

                    ObjectMapper.Map(input, user);

                    // vai trò
                    var newUserRoleMapping = new List<UserRoleMapping>();
                    if (input.Roles != null)
                    {
                        foreach (var role in input.Roles)
                        {
                            var granted = userRoleMapping.RemoveAll(x => x.RoleId == role);
                            if (granted < 1)
                                newUserRoleMapping.Add(new UserRoleMapping(user.Id, role));
                        }
                    }

                    // phòng chức năng
                    var newUserRoomMapping = new List<UserRoomMapping>();
                    if (input.Rooms != null)
                    {
                        foreach (var room in input.Rooms)
                        {
                            var granted = userRoomMapping.RemoveAll(x => x.RoomId == room);
                            if (granted < 1)
                                newUserRoomMapping.Add(new UserRoomMapping(user.Id, room));
                        }
                    }

                    // xóa dữ liệu cũ
                    if (userRoleMapping.Any())
                        await _userRoleMappingRepository.BulkDeleteAsync(userRoleMapping);
                    if (userRoomMapping.Any())
                        await _userRoomMappingRepository.BulkDeleteAsync(userRoomMapping);

                    // lưu
                    await _userRepository.UpdateAsync(user);
                    if (newUserRoleMapping.Any())
                        await _userRoleMappingRepository.BulkInsertAsync(newUserRoleMapping);
                    if (newUserRoomMapping.Any())
                        await _userRoomMappingRepository.BulkInsertAsync(newUserRoomMapping);

                    unitOfWork.Complete();
                    result.Success(input);
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

        public Task DeActivate(EntityDto<long> user)
        {
            throw new NotImplementedException();
        }

        public Task Activate(EntityDto<long> user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ChangePassword(ChangePasswordDto input)
        {
            throw new NotImplementedException();
        }
    }
}
