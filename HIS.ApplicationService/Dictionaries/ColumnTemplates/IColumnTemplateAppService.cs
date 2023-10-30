using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Dictionaries.ColumnTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.ColumnTemplates
{
    public interface IColumnTemplateAppService
    {
        Task<PagedResultDto<ColumnTemplateDto>> GetAll(PagedColumnTemplateResultRequestDto input);
        Task<ResultDto<ColumnTemplateDto>> CreateOrEdit(CreateOrEditColumnTemplateDto input);
    }
}
