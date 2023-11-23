using HIS.Application.Core.Services;
using HIS.Dtos.Business.Receptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Receptions
{
    public interface IReceptionAppService : IBaseCrudAppService<ReceptionDto, Guid, GetAllReceptionInput>
    {
    }
}
