using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Application.Core.Services.Dto
{
    public interface IPagedResultRequestDto
    {
        int MaxResultCount { get; set; }
        int SkipCount { get; set; }

        string Filter { get; set; }
    }
}
