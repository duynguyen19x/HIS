﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Services.Dto
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

        public virtual void Succeeded(T result)
        {
            this.IsSucceeded = true;
            this.Result = result;
        }

        public virtual void Exception(Exception ex)
        {
            this.IsSucceeded = false;
            this.Message = ex.Message;
        }
    }
}
