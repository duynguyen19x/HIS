using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Systems.SYSRefType;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.SYSRefType
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
