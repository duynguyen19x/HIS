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

        public IList<T> Items
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
        public bool IsSuccessed { get; set; } = true;
        public string Message { get; set; }

        public ListResultDto()
        {
        }

        public ListResultDto(IList<T> items)
        {
            Items = items;
        }
    }
}
