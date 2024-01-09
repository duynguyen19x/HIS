using HIS.Application.Core.Services;
using HIS.Dtos.Systems.RefType;
using HIS.Dtos.Systems;
using HIS.Application.Core.Services.Dto;
using HIS.EntityFrameworkCore;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using HIS.Core.Linq;
using HIS.Core.Repositories;
using HIS.EntityFrameworkCore.Entities.Systems;

namespace HIS.ApplicationService.Systems.RefType
{
    public class SYSRefTypeAppService : BaseCrudAppService<SYSRefTypeDto, int, GetAllSYSRefTypeInputDto>, ISYSRefTypeAppService
    {
        private readonly IRepository<SYSRefType, int> _sysRefTypeRepository;

        public SYSRefTypeAppService(HISDbContext context, IMapper mapper, IRepository<SYSRefType, int> sysRefTypeRepository) 
            : base(context, mapper)
        {
            _sysRefTypeRepository = sysRefTypeRepository;
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
                //var filter = Context.SYSRefTypes.AsNoTracking()
                var filter = _sysRefTypeRepository.GetAll()
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
