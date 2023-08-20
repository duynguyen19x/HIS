using HIS.Application.Core.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Business.DImpExpMestType;
using HIS.Dtos.Systems.SYSRefType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.SYSRefType
{
    public interface ISYSRefTypeAppService : IBaseAppService
    {
        Task<PagedResultDto<SYSRefTypeDto>> GetAll(GetAllSYSRefTypeInputDto input);
    }
}
