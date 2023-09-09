using Microsoft.EntityFrameworkCore;

namespace HIS.EntityFrameworkCore.EntityFrameworkCore.Seeds
{
    public static class SeedHelper
    {
        public static void Seed2(this ModelBuilder modelBuilder)
        {
        }
    }

    public interface ISeed
    {
        void Seed(ModelBuilder modelBuilder);
    }
}
