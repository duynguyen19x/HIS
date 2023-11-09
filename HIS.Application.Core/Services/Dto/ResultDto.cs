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

        public virtual IList<ResultErrorDto> Errors { get; set; }

        public virtual bool HasErrors => Errors != null && Errors.Count > 0;

        public ResultDto() 
        {
            IsSucceeded = true;
            Errors = new List<ResultErrorDto>();
        }
        public ResultDto(T item) 
            : this()
        {
            Item = item;
        }

        public virtual void Error(string field, string message)
        {
            if (Errors == null)
                Errors = new List<ResultErrorDto>();
            Errors.Add(new ResultErrorDto(field, message));
        }
        public virtual void RemoveError()
        {
            this.Errors = new List<ResultErrorDto>();
        }
        public virtual void Exception(Exception ex)
        {
            this.IsSucceeded = false;
            this.Message = ex.Message;
        }
    }
}
