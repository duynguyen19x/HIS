﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.EntityFrameworkCore.Entities.Dictionaries;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class RoomConfiguration : IEntityTypeConfiguration<SRoom>
    {
        public void Configure(EntityTypeBuilder<SRoom> builder)
        {
            builder.ToTable("SRooms");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Code).HasMaxLength(50).IsRequired(); ;
            builder.Property(x => x.Name).HasMaxLength(512).IsRequired(); ;
            builder.Property(x => x.Description).HasMaxLength(512);

            builder.HasOne(t => t.Department)
                .WithMany(p => p.Rooms)
                .HasForeignKey(p => p.DepartmentId)
                .IsRequired();
        }
    }
}