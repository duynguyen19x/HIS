using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Business.Receptions;
using HIS.Dtos.Dictionaries.ColumnTemplates;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.ColumnTemplate
{
    public class ColumnTemplateAppService : BaseAppService, IColumnTemplateAppService
    {
        public ColumnTemplateAppService(HISDbContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public virtual async Task<PagedResultDto<ColumnTemplateDto>> GetAll(GetAllColumnTemplateInput input)
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
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public virtual async Task<ResultDto<ColumnTemplateDto>> Create(CreateOrEditColumnTemplateDto input)
        {
            return null;
        }

        public virtual async Task<ResultDto<ColumnTemplateDto>> Update(CreateOrEditColumnTemplateDto input)
        {
            return null;
        }

        public virtual async Task<ResultDto<ColumnTemplateDto>> Delete(Guid id)
        {
            var result = new ResultDto<ColumnTemplateDto>();
            using (var transaction = Context.BeginTransaction())
            {
                try
                {
                    var data = Context.ColumnTemplates.SingleOrDefault(x => x.Id == id);
                    if (data != null)
                    {
                        Context.ColumnTemplates.Remove(data);
                        await Context.SaveChangesAsync();

                        transaction.Commit();
                    }    
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                }
            }    
                
            return result;
        }
    }
}
