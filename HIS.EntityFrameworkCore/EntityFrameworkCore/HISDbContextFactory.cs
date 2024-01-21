using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace HIS.EntityFrameworkCore
{
    public class HISDbContextFactory : IDesignTimeDbContextFactory<HISDbContext>
    {
        public HISDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("HIS");

            var optionsBuilder = new DbContextOptionsBuilder<HISDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new HISDbContext(optionsBuilder.Options);
        }
    }
}
