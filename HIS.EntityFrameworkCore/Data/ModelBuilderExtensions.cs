using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Categories.Patients;
using HIS.Utilities.Commons;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            GenderBuilder.Seed(modelBuilder);
            UserBuilder.Seed(modelBuilder);
            ServiceGroupBuilder.Seed(modelBuilder);
            PatientTypeBuilder.Seed(modelBuilder);
        }
    }
}
