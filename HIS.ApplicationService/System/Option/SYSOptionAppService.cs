using HIS.ApplicationService.Systems.Option.Dtos;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.Option
{
    public class SYSOptionAppService : BaseAppService, ISYSOptionAppService
    {
        private readonly IRepository<SYSOption, Guid> _sysOptionRepository;

        public SYSOptionAppService(IRepository<SYSOption, Guid> sysOptionRepository)
        {
            _sysOptionRepository = sysOptionRepository;
        }

        public async Task<ResultDto<SYSOptionDto>> CreateOrUpdateAsync(SYSOptionDto input)
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

        public Task<ResultDto<SYSOptionDto>> CreateAsync(SYSOptionDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<SYSOptionDto>> UpdateAsync(SYSOptionDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<SYSOptionDto>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<SYSOptionDto>> GetAllAsync(GetAllSYSOptionInputDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<SYSOptionDto>> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
