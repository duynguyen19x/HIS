using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Application.Services.Dto
{
    public interface IPagedResult<T> : IListResult<T>, IHasTotalCount
    {
    }
}
