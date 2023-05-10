using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Base
{
    public class EntityDto<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
    }
}
