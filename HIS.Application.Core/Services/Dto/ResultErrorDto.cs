using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Application.Core.Services.Dto
{
    public class ResultErrorDto
    {
        public virtual string FieldName { get; set; }
        public virtual string Message { get; set; }

        public ResultErrorDto() { }
        public ResultErrorDto(string field, string message)
        {
            this.FieldName = field;
            this.Message = message;
        }
    }
}
