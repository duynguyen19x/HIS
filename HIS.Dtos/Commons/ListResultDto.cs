using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Commons
{
    [Serializable]
    public class ListResultDto<T> : IListResult<T>
    {
        private IReadOnlyList<T> _items;

        //
        // Summary:
        //     List of items.
        public IReadOnlyList<T> Items
        {
            get
            {
                return _items ?? (_items = new List<T>());
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
