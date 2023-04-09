using HIS.EntityFrameworkCore.BaseEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Categories.Others
{
    public class SProvince : Entity<Guid>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public Guid? NationalId { get; set; }
        public bool IsAcctive { get; set; }

        public SNational National { get; set; }
        public IList<SCommune> Communes { get; set; }
        public IList<SDistrict> Districts { get; set; }
    }
}
