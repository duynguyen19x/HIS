using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Application.Services.Dto
{
    [Serializable]
    public class PagedResultRequestDto : IPagedResultRequest
    {
        public virtual string Filter { get; set; }

        [Range(0, int.MaxValue)]
        public virtual int MaxResultCount { get; set; }

        public virtual int SkipCount { get; set; }

        public PagedResultRequestDto()
        {
            MaxResultCount = int.MaxValue;
            SkipCount = 0;
        }
    }
}
