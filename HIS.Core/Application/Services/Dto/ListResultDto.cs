using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Application.Services.Dto
{
    [Serializable]
    public class ListResultDto<T> : ResultDto, IListResult<T>
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

        public ListResultDto()
        {
        }

        public ListResultDto(IList<T> items)
        {
            Result = items;
        }
    }
}
