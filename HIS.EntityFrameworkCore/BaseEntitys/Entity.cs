using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.BaseEntitys
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }

    public class Entity<TKey> : IEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}
