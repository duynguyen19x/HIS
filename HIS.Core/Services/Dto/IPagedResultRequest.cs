using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Services.Dto
{
    public interface IPagedResultRequest
    {
        int MaxResultCount { get; set; }
        int SkipCount { get; set; }

        /// <summary>
        /// Sorting information.
        /// Should include sorting field and optionally a direction (ASC or DESC)
        /// Can contain more than one field separated by comma (,).
        /// </summary>
        /// <example>
        /// Examples:
        /// "Name"
        /// "Name DESC"
        /// "Name ASC, Age DESC"
        /// </example>
        string Sorting { get; set; }

        string Filter { get; set; }
    }
}
