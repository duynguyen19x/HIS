﻿using HIS.EntityFrameworkCore.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Systems
{
    public class SYSOptionConfiguration : IEntityTypeConfiguration<SYSOption>
    {
        public void Configure(EntityTypeBuilder<SYSOption> builder)
        {
            
        }
    }
}