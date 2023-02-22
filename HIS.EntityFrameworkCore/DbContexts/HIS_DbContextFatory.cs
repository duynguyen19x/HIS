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
    public class HIS_DbContextFatory : IDesignTimeDbContextFactory<HIS_DbContext>
    {
        public HIS_DbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("HIS");

            var optionsBuilder = new DbContextOptionsBuilder<HIS_DbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new HIS_DbContext(optionsBuilder.Options);
        }
    }
}
