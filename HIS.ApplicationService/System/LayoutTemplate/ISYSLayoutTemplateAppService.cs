using HIS.ApplicationService.Systems.LayoutTemplate.Dtos;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.Branchs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.LayoutTemplate
{
    public interface ISYSLayoutTemplateAppService : IAppService
    {
        Task<PagedResultDto<SYSLayoutTemplateDto>> GetAllAsync(GetAllSYSLayoutTemplateInputDto input);

        Task<ResultDto<SYSLayoutTemplateDto>> GetAsync(Guid id);

        Task<ResultDto<SYSLayoutTemplateDto>> CreateOrUpdateAsync(SYSLayoutTemplateDto input);

        Task<ResultDto<SYSLayoutTemplateDto>> DeleteAsync(Guid id);
    }
}
