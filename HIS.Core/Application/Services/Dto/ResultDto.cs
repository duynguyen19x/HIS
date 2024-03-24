using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Application.Services.Dto
{
    public class ResultDto
    {
        public virtual bool IsSucceeded { get; set; }

        public virtual string Message { get; set; }

        public ResultDto()
        {
            IsSucceeded = true;
        }
    }

    public class ResultDto<T> : ResultDto
    {
        public virtual T Result { get; set; }

        public ResultDto()
        {
            IsSucceeded = true;
        }

        public ResultDto(T result)
            : this()
        {
            Result = result;
        }

        public virtual void Success(T result)
        {
            IsSucceeded = true;
            Result = result;
        }

        public virtual void Exception(Exception ex)
        {
            IsSucceeded = false;
            Message = ex.Message;
        }
    }
}
