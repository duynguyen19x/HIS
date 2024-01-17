using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Services.Dto
{
    [Serializable]
    public class PagedResultRequestDto : IPagedResultRequest
    {
        public virtual int MaxResultCount { get; set; }
        public virtual int SkipCount { get; set; }
        public string Sorting { get; set; }
        public virtual string Filter { get; set; }

        public PagedResultRequestDto()
        {
            MaxResultCount = int.MaxValue;
            SkipCount = 0;
        }
    }
}
