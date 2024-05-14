using HIS.Core.Enums;
using HIS.EntityFrameworkCore.Entities.Dictionary;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HIS.EntityFrameworkCore.Entities;

namespace HIS.EntityFrameworkCore.Configurations.Dictionary
{
    public class RelationshipConfiguration : IEntityTypeConfiguration<Relationship>
    {
        public void Configure(EntityTypeBuilder<Relationship> builder)
        {
            builder.HasData(
                new Relationship { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F01"), RelationshipCode = "01", RelationshipName = "Bố đẻ", SortOrder = 1 },
                new Relationship { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F02"), RelationshipCode = "02", RelationshipName = "Mẹ đẻ", SortOrder = 2 },
                new Relationship { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F03"), RelationshipCode = "03", RelationshipName = "Bố nuôi", SortOrder = 3 },
                new Relationship { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F04"), RelationshipCode = "04", RelationshipName = "Mẹ nuôi", SortOrder = 4 },
                new Relationship { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F05"), RelationshipCode = "05", RelationshipName = "Anh ruột", SortOrder = 5 },
                new Relationship { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F06"), RelationshipCode = "06", RelationshipName = "Chị ruột", SortOrder = 6 },
                new Relationship { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F07"), RelationshipCode = "07", RelationshipName = "Em ruột", SortOrder = 7 },
                new Relationship { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F08"), RelationshipCode = "08", RelationshipName = "Ông", SortOrder = 8 },
                new Relationship { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F09"), RelationshipCode = "09", RelationshipName = "Bà", SortOrder = 9 },
                new Relationship { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F10"), RelationshipCode = "10", RelationshipName = "Vợ", SortOrder = 10 },
                new Relationship { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F11"), RelationshipCode = "11", RelationshipName = "Chồng", SortOrder = 11 },
                new Relationship { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F12"), RelationshipCode = "12", RelationshipName = "Con", SortOrder = 12 },
                new Relationship { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F13"), RelationshipCode = "13", RelationshipName = "Cháu", SortOrder = 13 },
                new Relationship { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F14"), RelationshipCode = "14", RelationshipName = "Bác, chú, cậu", SortOrder = 14 },
                new Relationship { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F15"), RelationshipCode = "15", RelationshipName = "Bác, cô, dì", SortOrder = 15 },
                new Relationship { Id = new Guid("DD0FB418-CD3F-40CD-8C12-7FDA1CF56F99"), RelationshipCode = "99", RelationshipName = "Khác", SortOrder = 99 }
                );
        }
    }
}
