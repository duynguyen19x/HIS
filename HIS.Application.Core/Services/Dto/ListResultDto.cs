using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Application.Core.Services.Dto
{
    [Serializable]
    public class ListResultDto<T> : IListResult<T>
    {
        private IList<T> _result;

        public virtual IList<T> Result
        {
            get
            {
                if (_result == null)
                    _result = new List<T>();
                return _result;
            }
            set
            {
                _result = value;
            }
        }
        public virtual bool IsSucceeded { get; set; } = true;
        public virtual string Message { get; set; }

        public ListResultDto()
        {
        }

        public ListResultDto(IList<T> items)
        {
            Result = items;
        }
    }
}
