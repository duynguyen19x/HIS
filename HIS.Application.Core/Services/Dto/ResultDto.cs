using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Application.Core.Services.Dto
{
    public class ResultDto<T>
    {
        public virtual bool IsSuccessed { get; set; }

        public virtual string Message { get; set; }

        public virtual T Item { get; set; }

        public ResultDto() 
        {
            IsSuccessed = true;
        }
        public ResultDto(T item) 
            : this()
        {
            Item = item;
        }
    }
}
