using HIS.ApplicationService.Systems.Permission.Dtos;
using HIS.ApplicationService.Systems.User.Dtos;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.Dtos.Dictionaries.Branchs;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HIS.ApplicationService.Systems.User
{
    public class SYSUserAppService : BaseAppService, ISYSUserAppService
    {
        private readonly IRepository<SYSUser, Guid> _sysUserRepository;
        private readonly IRepository<SYSRole, Guid> _sysRoleRepository;

        public SYSUserAppService(
            IRepository<SYSUser, Guid> sysUserRepository,
            IRepository<SYSRole, Guid> sysRoleRepository) 
        {
            _sysRoleRepository = sysRoleRepository;
            _sysUserRepository = sysUserRepository;
        }

        public async Task<PagedResultDto<SYSUserDto>> GetAllAsync(GetAllSYSUserInputDto input)
        {
            var result = new PagedResultDto<SYSUserDto>();
            try
            {
                var filter = _sysUserRepository.GetAll();
                var pagedAndSorted = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<SYSUserDto>>(pagedAndSorted.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async Task<ResultDto<SYSUserDto>> GetAsync(Guid id)
        {
            var result = new ResultDto<SYSUserDto>();
            try
            {
                var entity = await _sysUserRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<SYSUserDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async Task<ResultDto<SYSUserDto>> CreateOrUpdateAsync(SYSUserDto input)
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

        public async Task<ResultDto<SYSUserDto>> CreateAsync(SYSUserDto input) 
        {
            var result = new ResultDto<SYSUserDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var entity = ObjectMapper.Map<SYSUser>(input);

                    await _sysUserRepository.InsertAsync(entity);
                    unitOfWork.Complete();

                    result.Result = ObjectMapper.Map<SYSUserDto>(entity);
                    result.IsSucceeded = true;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async Task<ResultDto<SYSUserDto>> UpdateAsync(SYSUserDto input) 
        {
            var result = new ResultDto<SYSUserDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin())
            {
                try
                {
                    var entity = await _sysUserRepository.GetAsync(input.Id.GetValueOrDefault());

                    ObjectMapper.Map(input, entity);
                    unitOfWork.Complete();

                    result.Result = ObjectMapper.Map<SYSUserDto>(entity);
                    result.IsSucceeded = true;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async Task<ResultDto<SYSUserDto>> DeleteAsync(Guid id)
        {
            var result = new ResultDto<SYSUserDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin())
            {
                try
                {
                    var entity = _sysUserRepository.Get(id);
                    await _sysUserRepository.DeleteAsync(entity);

                    unitOfWork.Complete();

                    result.Result = ObjectMapper.Map<SYSUserDto>(entity);
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
