using HIS.Core.Enums;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public class DeathCauseBuilder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeathCause>().HasData(
                new DeathCause((int)DeathCauses.DISEASE, DeathCauses.DISEASE.ToString(), "Do bệnh", null, 1, false),
                new DeathCause((int)DeathCauses.COMPLICATION, DeathCauses.COMPLICATION.ToString(), "Do tai biến điều trị", null, 2, false),
                new DeathCause((int)DeathCauses.OTHER, DeathWithins.OTHER.ToString(), "Khác", null, 99, false));
        }
    }
}
