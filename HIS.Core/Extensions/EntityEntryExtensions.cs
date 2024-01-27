using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Core.Extensions
{
    public static class EntityEntryExtensions
    {
        public static bool CheckOwnedEntityChange(this EntityEntry entry)
        {
            if (entry.State != EntityState.Modified)
            {
                return entry.References.Any((ReferenceEntry r) => r.TargetEntry != null && r.TargetEntry!.Metadata.IsOwned() && r.TargetEntry.CheckOwnedEntityChange());
            }    
            return true;
        }
    }
}
