using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Application.Services.Dto
{
    [Serializable]
    public class ListResultDto<T> : IListResult<T>
    {
        private IReadOnlyList<T> _items;

        public IReadOnlyList<T> Items
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

        public ListResultDto()
        {
        }

        public ListResultDto(IReadOnlyList<T> items)
        {
            Items = items;
        }
    }
}
