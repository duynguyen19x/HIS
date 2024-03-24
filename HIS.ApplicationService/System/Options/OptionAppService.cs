using HIS.ApplicationService.System.Options.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities.System;

namespace HIS.ApplicationService.System.Options
{
    public class OptionAppService : BaseAppService, IOptionAppService
    {
        private readonly IRepository<Option, Guid> _sysOptionRepository;

        public OptionAppService(IRepository<Option, Guid> sysOptionRepository)
        {
            _sysOptionRepository = sysOptionRepository;
        }

        public async Task<ResultDto<OptionDto>> CreateOrUpdateAsync(OptionDto input)
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

        public Task<ResultDto<OptionDto>> CreateAsync(OptionDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<OptionDto>> UpdateAsync(OptionDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<OptionDto>> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<OptionDto>> GetAllAsync(GetAllOptionInputDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<OptionDto>> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
