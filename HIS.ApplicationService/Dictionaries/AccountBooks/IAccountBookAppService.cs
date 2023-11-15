using HIS.Application.Core.Services;
using HIS.Dtos.Dictionaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.AccountBooks
{
    public interface IAccountBookAppService : IBaseCrudAppService<AccountBookDto, Guid, GetAllAccountBookInput>
    {
    }
}
