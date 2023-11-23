using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Application.Core.Services.Dto
{
    public class ResultDto<T>
    {
        public virtual bool IsSucceeded { get; set; }

        public virtual string Message { get; set; }

        public virtual T Item { get; set; }

        public ResultDto() 
        {
            IsSucceeded = true;
        }

        public ResultDto(T item) 
            : this()
        {
            Item = item;
        }

        public virtual void Succeeded(T item)
        {
            this.IsSucceeded = true;
            this.Item = item;
        }

        public virtual void Exception(Exception ex)
        {
            this.IsSucceeded = false;
            this.Message = ex.Message;
        }
    }
}
