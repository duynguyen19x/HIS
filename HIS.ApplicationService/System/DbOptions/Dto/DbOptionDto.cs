using HIS.Core.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Systems.DbOption
{
    public class DbOptionDto : EntityDto<Guid?>
    {
        public string DbOptionId { get; set; }
        public string DbOptionValue { get; set; }

        /// <summary>
        /// Loại: 0: string, 1: int, 2:decimal, 3: DateTime, 4: bool
        /// </summary>
        public int DbOptionType { get; set; }
        public string Description { get; set; }
        public Guid? ParentId { get; set; }
        public bool IsParent { get; set; }


    }
}
