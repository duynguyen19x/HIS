using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Business.Receptions;
using HIS.Dtos.Dictionaries.ColumnTemplates;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.ColumnTemplates
{
    public class ColumnTemplateAppService : BaseAppService, IColumnTemplateAppService
    {
        public ColumnTemplateAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public virtual async Task<PagedResultDto<ColumnTemplateDto>> GetAll(PagedColumnTemplateResultRequestDto input)
        {
            var result = new PagedResultDto<ColumnTemplateDto>();
            try
            {
                var filter = Context.ColumnTemplates.AsQueryable()
                    .WhereIf(!string.IsNullOrEmpty(input.TemplateNameFilter), x => x.TemplateName == input.TemplateNameFilter)
                    .WhereIf(input.MaxRefTypeFilter != null, x => x.RefType <= input.MaxRefTypeFilter)
                    .WhereIf(input.MinRefTypeFilter != null, x => x.RefType >= input.MinRefTypeFilter);
                var paged = await filter.PageBy(input).ToListAsync();
                var totalCount = await filter.CountAsync();
                result.Items = ObjectMapper.Map<IList<ColumnTemplateDto>>(paged);
                result.TotalCount = totalCount;
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }
            return result;
        }

        public virtual async Task<ResultDto<ColumnTemplateDto>> CreateOrEdit(CreateOrEditColumnTemplateDto input)
        {
            var result = new ResultDto<ColumnTemplateDto>();
            using (var transaction  = Context.BeginTransaction())
            {
                try
                {
                    var inputDels = Context.ColumnTemplates.Where(x => x.RefType == input.RefType && x.TemplateName == input.TemplateName).ToList();
                    if (inputDels != null)
                        Context.ColumnTemplates.RemoveRange(inputDels);

                    var columns = new List<ColumnTemplate>();
                    foreach (var inputDetail in input.Details)
                    {
                        if (inputDetail.Id == default(Guid))
                            inputDetail.Id = Guid.NewGuid();
                        inputDetail.RefType = input.RefType;
                        inputDetail.TemplateName = input.TemplateName;

                        var column = ObjectMapper.Map<ColumnTemplate>(inputDetail);
                    }
                    var columnTemplates = ObjectMapper.Map<IList<ColumnTemplate>>(input.Details);
                    if (columnTemplates != null)
                        Context.ColumnTemplates.AddRange(columnTemplates);

                    await SaveChangesAsync();
                    transaction.Commit();
                }
                catch (Exception ex)
                { 
                    result.IsSucceeded = false;
                    result.Message = ex.Message;
                }
            }
            return result;
        }
    }
}
