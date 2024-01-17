using HIS.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Services.Dto
{
    [Serializable]
    public class EntityDto : IEntityDto
    {
    }

    [Serializable]
    public class EntityDto<TPrimaryKey> : IEntityDto<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
    }
}
