using HIS.Application.Core.Services;
using HIS.Dtos.Systems;
using HIS.Dtos.Systems.RefType;
using HIS.EntityFrameworkCore.Entities.Systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Systems.RefType
{
    public interface ISYSRefTypeAppService : IBaseCrudAppService<SYSRefTypeDto, int, GetAllSYSRefTypeInputDto>
    {
    }
}
