﻿using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionary
{
    public class InvoiceTypeConfiguration : IEntityTypeConfiguration<InvoiceType>
    {
        public void Configure(EntityTypeBuilder<InvoiceType> builder)
        {
            builder.HasData(new List<InvoiceType>
            {
                new InvoiceType() { Id = 1, Code = "TT", Name = "Thu tiền", SortOrder = 1 },
                new InvoiceType() { Id = 2, Code = "HT", Name = "Hoàn tiền", SortOrder = 2 },
                new InvoiceType() { Id = 3, Code = "TU", Name = "Tạm ứng", SortOrder = 3 },
                new InvoiceType() { Id = 4, Code = "HU", Name = "Hoàn ứng", SortOrder = 4 },
            });
        }
    }
}
