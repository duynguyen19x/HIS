using HIS.Application.Core.Services;
using HIS.Dtos.Systems.RefType;
using HIS.Dtos.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.Application.Core.Services.Dto;
using HIS.EntityFrameworkCore;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using HIS.Core.Linq;
using HIS.Dtos.Dictionaries.Branchs;

namespace HIS.ApplicationService.Systems.RefType
{
    public class SYSRefTypeAppService : BaseCrudAppService<SYSRefTypeDto, int, GetAllSYSRefTypeInputDto>, ISYSRefTypeAppService
    {
        public SYSRefTypeAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public override Task<ResultDto<SYSRefTypeDto>> Create(SYSRefTypeDto input)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<SYSRefTypeDto>> Update(SYSRefTypeDto input)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<SYSRefTypeDto>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override async Task<PagedResultDto<SYSRefTypeDto>> GetAll(GetAllSYSRefTypeInputDto input)
        {
            var result = new PagedResultDto<SYSRefTypeDto>();
            try
            {
                var filter = Context.SYSRefTypes.AsNoTracking()
                    .WhereIf(!string.IsNullOrEmpty(input.RefTypeNameFilter), x => x.RefTypeName == input.RefTypeNameFilter)
                    .WhereIf(input.RefTypeCategoryFilter != null, x => x.RefTypeCategoryID == input.RefTypeCategoryFilter);

                var paged = filter.OrderBy(s => s.RefTypeCategoryID).ThenBy(t => t.SortOrder).PageBy(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<SYSRefTypeDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public override Task<ResultDto<SYSRefTypeDto>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
