using HIS.EntityFrameworkCore.BaseEntitys;
using HIS.EntityFrameworkCore.Entities.Categories.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories
{
    public class SPricePolicy : FullAuditingEntity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Inactive { get; set; }

        public IList<SServicePricePolicy> SServicePricePolicies { get; set; }
    }
}
