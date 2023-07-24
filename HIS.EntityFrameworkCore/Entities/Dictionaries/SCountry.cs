using HIS.EntityFrameworkCore.BaseEntitys;
using HIS.EntityFrameworkCore.Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Quốc gia.
    /// </summary>
    public class SCountry : Entity<Guid>
    {
        public string Code { get; set; }
        public string HeInCode { get; set; }
        public string Name { get; set; }
        public bool Inactive { get; set; }

        public virtual IList<SProvince> Provinces { get; set; }
        public virtual IList<SMedicine> SMedicines { get; set; }
        public virtual IList<SMedicineType> SMedicineTypes { get; set; }
    }
}
