using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Application.Services.Dto
{
    [Serializable]
    public class EntityDto<TPrimaryKey> : IEntityDto<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }

        public EntityDto()
        {
        }

        public EntityDto(TPrimaryKey id)
        {
            Id = id;
        }
    }
}
