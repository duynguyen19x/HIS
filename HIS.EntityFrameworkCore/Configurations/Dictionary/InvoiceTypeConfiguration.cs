using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Dictionary
{
    public class InvoiceTypeConfiguration : IEntityTypeConfiguration<InvoiceType>
    {
        public void Configure(EntityTypeBuilder<InvoiceType> builder)
        {
            builder.HasData(new List<InvoiceType>
            {
                new InvoiceType() { CreatedDate = new DateTime(2024, 1, 1), Id = 1, Code = "TT", Name = "Thu tiền", SortOrder = 1 },
                new InvoiceType() { CreatedDate = new DateTime(2024, 1, 1), Id = 2, Code = "HT", Name = "Hoàn tiền", SortOrder = 2 },
                new InvoiceType() { CreatedDate = new DateTime(2024, 1, 1), Id = 3, Code = "TU", Name = "Tạm ứng", SortOrder = 3 },
                new InvoiceType() { CreatedDate = new DateTime(2024, 1, 1), Id = 4, Code = "HU", Name = "Hoàn ứng", SortOrder = 4 },
            });
        }
    }
}
