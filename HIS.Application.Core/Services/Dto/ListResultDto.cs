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
        private IList<T> _items;

        public virtual IList<T> Items
        {
            get
            {
                if (_items == null)
                    _items = new List<T>();
                return _items;
            }
            set
            {
                _items = value;
            }
        }
        public virtual bool IsSucceeded { get; set; } = true;
        public virtual string Message { get; set; }

        public ListResultDto()
        {
        }

        public ListResultDto(IList<T> items)
        {
            Items = items;
        }
    }
}
