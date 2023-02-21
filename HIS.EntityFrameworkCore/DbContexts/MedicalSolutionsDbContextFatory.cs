using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.DbContexts
{
    public class MedicalSolutionsDbContextFatory : IDesignTimeDbContextFactory<MedicalSolutionsDbContext>
    {
        public MedicalSolutionsDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("HIS");

            var optionsBuilder = new DbContextOptionsBuilder<MedicalSolutionsDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new MedicalSolutionsDbContext(optionsBuilder.Options);
        }
    }
}
