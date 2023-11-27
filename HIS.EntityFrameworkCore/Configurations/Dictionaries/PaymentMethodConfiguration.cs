﻿using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
    {
        public void Configure(EntityTypeBuilder<PaymentMethod> builder)
        {
            builder.ToTable("PaymentMethod");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.PaymentMethodCode).HasMaxLength(20).IsRequired();
            builder.Property(x => x.PaymentMethodName).HasMaxLength(128).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(255);

            builder.HasData(
                new PaymentMethod { Id = new Guid("8BFF9824-1DF2-419E-88AB-E098A6FC4E7E"), PaymentMethodCode = "TM", PaymentMethodName = "Tiền mặt", SortOrder = 1 },
                new PaymentMethod { Id = new Guid("DD39AFC0-1DE0-4287-A126-4DADA6788508"), PaymentMethodCode = "CK", PaymentMethodName = "Chuyển khoản", SortOrder = 2 },
                new PaymentMethod { Id = new Guid("0B348363-C888-4C9A-B145-C3389FDCCA37"), PaymentMethodCode = "TM/CK", PaymentMethodName = "Tiền mặt hoặc chuyển khoản", SortOrder = 3 }
                );
        }
    }
}