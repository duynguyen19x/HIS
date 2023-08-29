using HIS.Core.Enums;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public class DeathWithinBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeathWithin>().HasData(
                new DeathWithin((int)DeathWithins.WITHIN_24H, DeathWithins.WITHIN_24H.ToString(), "Trong 24h vào", null, 1, false),
                new DeathWithin((int)DeathWithins.WITHIN_48H, DeathWithins.WITHIN_48H.ToString(), "Trong 48h vào", null, 2, false),
                new DeathWithin((int)DeathWithins.WITHIN_72H, DeathWithins.WITHIN_72H.ToString(), "Trong 72h vào", null, 3, false),
                new DeathWithin((int)DeathWithins.OTHER, DeathWithins.OTHER.ToString(), "Khác", null, 99, false));
        }
    }
}
