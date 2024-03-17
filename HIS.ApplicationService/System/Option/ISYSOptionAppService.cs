using HIS.ApplicationService.Systems.LayoutTemplate.Dtos;
using HIS.ApplicationService.Systems.Option.Dtos;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.Option
{
    public interface ISYSOptionAppService : IAppService
    {
        Task<PagedResultDto<SYSOptionDto>> GetAllAsync(GetAllSYSOptionInputDto input);

        Task<ResultDto<SYSOptionDto>> GetAsync(Guid id);

        Task<ResultDto<SYSOptionDto>> CreateOrUpdateAsync(SYSOptionDto input);

        Task<ResultDto<SYSOptionDto>> DeleteAsync(Guid id);
    }
}
