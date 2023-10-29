using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Dictionaries.ColumnTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.ColumnTemplate
{
    public interface IColumnTemplateAppService
    {
        Task<PagedResultDto<ColumnTemplateDto>> GetAll(GetAllColumnTemplateInput input);
        Task<ResultDto<ColumnTemplateDto>> CreateOrEdit(CreateOrEditColumnTemplateDto input);
        Task<ResultDto<ColumnTemplateDto>> Delete(Guid id);
    }
}
