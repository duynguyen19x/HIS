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
    internal class ReceptionTypeBuilder
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<ReceptionType>().HasData(
                new ReceptionType((int)ReceptionTypes.KHAMBENH, "KB", "Khám bệnh", 1),
                new ReceptionType((int)ReceptionTypes.CAPCUU, "CC", "Cấp cứu", 2)
                );
        }
    }
}
