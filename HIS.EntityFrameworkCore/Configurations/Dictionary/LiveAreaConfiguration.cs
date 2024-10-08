﻿using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HIS.EntityFrameworkCore.Configurations.Dictionaries
{
    public class LiveAreaConfiguration : IEntityTypeConfiguration<LiveArea>
    {
        public void Configure(EntityTypeBuilder<LiveArea> builder)
        {
            var data = new List<LiveArea>();
            data.Add(new LiveArea() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("B3EB4635-31FF-4E3F-B55F-A02150017BD7"), Code = "K1", MediCode = "K1", Name = "K1", SortOrder = 1 });
            data.Add(new LiveArea() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("DDB7F2CD-BE11-495B-80C0-51295E2066B9"), Code = "K2", MediCode = "K2", Name = "K2", SortOrder = 2 });
            data.Add(new LiveArea() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("0A14BAE0-EEB9-48B3-B49E-B3BB5B1492B1"), Code = "K3", MediCode = "K3", Name = "K3", SortOrder = 3 });
            builder.HasData(data);
        }
    }
}
