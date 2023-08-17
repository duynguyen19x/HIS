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
        [Range(1, int.MaxValue)]
        public virtual int MaxResultCount { get; set; } = int.MaxValue;

        [Range(0, int.MaxValue)]
        public virtual int SkipCount { get; set; } = 0;

        public virtual string Filter { get; set; }
    }
}
