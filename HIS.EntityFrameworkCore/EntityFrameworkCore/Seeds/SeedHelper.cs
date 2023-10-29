using Microsoft.EntityFrameworkCore;

namespace HIS.EntityFrameworkCore.EntityFrameworkCore.Seeds
{
    public static class SeedHelper
    {
        public static void Seed2(this ModelBuilder modelBuilder)
        {
            var type = typeof(ISeed);
            var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes()).Where(p => type.IsAssignableFrom(p)) as IEnumerable<ISeed>;
            if (types != null)
            {
                foreach (var seed in types)
                {
                    seed.Seed(modelBuilder);
                }    
            }
        }
    }

    public interface ISeed
    {
        void Seed(ModelBuilder modelBuilder);
    }
}
