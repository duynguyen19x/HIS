using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Application.Core.Services.Dto
{
    [Serializable]
    public abstract class PagedResultRequestDto : IPagedResultRequestDto
    {
        public virtual string Filter { get; set; }

        public virtual int MaxResultCount { get; set; }

        public virtual int SkipCount { get; set; }

        public PagedResultRequestDto()
        {
            MaxResultCount = int.MaxValue;
            SkipCount = 0;
        }
    }
}
