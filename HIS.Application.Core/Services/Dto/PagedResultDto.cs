using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Application.Core.Services.Dto
{
    [Serializable]
    public class PagedResultDto<T> : ListResultDto<T>, IPagedResult<T>, IListResult<T>
    {
        public virtual int TotalCount { get; set; }

        public PagedResultDto()
        {
        }

        public PagedResultDto(int totalCount, IList<T> items)
            : base(items)
        {
            TotalCount = totalCount;
        }

        public void Exception(Exception ex)
        {
            this.IsSuccessed = false;
            this.Message = ex.Message;
        }
    }
}
