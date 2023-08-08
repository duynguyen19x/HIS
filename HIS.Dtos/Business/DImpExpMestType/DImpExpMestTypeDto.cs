using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Business.DImpExpMestType
{
    public class DImpExpMestTypeDto : EntityDto<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Inactive { get; set; }
    }
}
