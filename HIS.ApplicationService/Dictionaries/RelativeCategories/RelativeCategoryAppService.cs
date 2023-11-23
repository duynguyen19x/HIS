using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Dictionaries.RelativeCategories;
using HIS.Dtos.Dictionaries.Relatives;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.RelativeCategories
{
    public class RelativeCategoryAppService : BaseCrudAppService<RelativeCategoryDto, Guid, GetAllRelativeCategoryInput>, IRelativeCategoryAppService
    {
        public RelativeCategoryAppService(HISDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async override Task<ResultDto<RelativeCategoryDto>> Create(RelativeCategoryDto input)
        {
            var result = new ResultDto<RelativeCategoryDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = ObjectMapper.Map<RelativeCategory>(input);
                    data.CreatedDate = DateTime.Now;
                    data.CreatedBy = SessionExtensions.Login?.Id;
                    Context.RelativeCategories.Add(data);
                    await SaveChangesAsync();
                    transaction.Commit();

                    result.IsSucceeded = true;
                    result.Item = input;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async override Task<ResultDto<RelativeCategoryDto>> Update(RelativeCategoryDto input)
        {
            var result = new ResultDto<RelativeCategoryDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var relativeCategory = await Context.RelativeCategories.FindAsync(input.Id);
                    var data = ObjectMapper.Map<RelativeCategory>(input);
                    data.CreatedDate = relativeCategory.CreatedDate;
                    data.CreatedBy = relativeCategory.CreatedBy;
                    data.ModifiedDate = DateTime.Now;
                    data.ModifiedBy = SessionExtensions.Login?.Id;
                    Context.RelativeCategories.Update(data);
                    await SaveChangesAsync();
                    transaction.Commit();

                    result.IsSucceeded = true;
                    result.Item = input;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async override Task<ResultDto<RelativeCategoryDto>> Delete(Guid id)
        {
            var result = new ResultDto<RelativeCategoryDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var relativeCategory = await Context.RelativeCategories.FindAsync(id);
                    Context.RelativeCategories.Remove(relativeCategory);

                    await SaveChangesAsync();
                    transaction.Commit();

                    result.IsSucceeded = true;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async override Task<PagedResultDto<RelativeCategoryDto>> GetAll(GetAllRelativeCategoryInput input)
        {
            var result = new PagedResultDto<RelativeCategoryDto>();
            try
            {
                var filter = Context.RelativeCategories.AsQueryable()
                    .WhereIf(!string.IsNullOrEmpty(input.RelativeCategoryCodeFilter), x => x.RelativeCategoryCode == input.RelativeCategoryCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.RelativeCategoryNameFilter), x => x.RelativeCategoryName == input.RelativeCategoryNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.OrderBy(s => s.Id).PageBy(input);

                result.TotalCount = await filter.CountAsync();
                result.Items = ObjectMapper.Map<IList<RelativeCategoryDto>>(paged.ToList());
                result.IsSuccessed = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async override Task<ResultDto<RelativeCategoryDto>> GetById(Guid id)
        {
            var result = new ResultDto<RelativeCategoryDto>();
            try
            {
                var relativeCategory = await Context.RelativeCategories.FindAsync(id);
                result.Item = ObjectMapper.Map<RelativeCategoryDto>(relativeCategory);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        
    }
}
