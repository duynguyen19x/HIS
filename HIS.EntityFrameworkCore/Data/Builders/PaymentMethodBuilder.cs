using HIS.EntityFrameworkCore.Constants;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public class PaymentMethodBuilder
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<PaymentMethod>().HasData(
                new PaymentMethod() { Id = new Guid("16B514CF-35B3-412C-93F1-8B6773593C4B"), Code = "TM", Name = "Tiền mặt", SortOrder = 1 },
                new PaymentMethod() { Id = new Guid("85F39AB1-2289-4D54-88D7-8D5EBAE219F0"), Code = "CK", Name = "Chuyển khoản", SortOrder = 2 }
                );
        }
    }
}
