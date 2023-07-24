using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public class ProvinceBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SProvince>().HasData(
                new SProvince() { Id = new Guid(""), Code = "", Name = "", CountryId = new Guid("0103BC86-7105-49C2-905A-CB83D3EE87C2") }
                );
        }
    }
}
