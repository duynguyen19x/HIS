using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Systems.SYSRefType;
using HIS.EntityFrameworkCore.EntityFrameworkCore;

namespace HIS.ApplicationService.Systems.RefType
{
    public class SYSRefTypeAppService : BaseAppService, ISYSRefTypeAppService
    {
        public SYSRefTypeAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async Task<PagedResultDto<SYSRefTypeDto>> GetAll(GetAllSYSRefTypeInputDto input)
        {
            return await new Task<PagedResultDto<SYSRefTypeDto>>(null);
        }
    }
}
