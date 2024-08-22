using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.EntityFrameworkCore.Seed
{
    public static class SeedHelper
    {
        private static object asyncObject = new object();

        public static void Seed<T>(this EntityTypeBuilder modelBuilder, IEnumerable<T> data) where T : class
        {
            var targetType = typeof(T);

            lock (asyncObject)
            {     
            }


        }    
    }
}
