using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Application.Services.Dto
{
    [Serializable]
    public class PagedResultDto<T> : ListResultDto<T>, IPagedResult<T>, IListResult<T>
    {
        public virtual int TotalCount { get; set; }

        public PagedResultDto()
        {
        }

        public PagedResultDto(int totalCount, IReadOnlyList<T> items)
            : base(items)
        {
            TotalCount = totalCount;
        }
    }
}
