using HIS.Core.Enums;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Data.Builders
{
    public class RelativeTypeBuilder
    {
        public static void Seed(ModelBuilder builder)
        {
            builder.Entity<RelativeType>().HasData(
                new RelativeType(new Guid("694A319F-11D3-4E0E-BF68-C99AA89B8D95"), "01", "Bố đẻ", 1),
                new RelativeType(new Guid("CCBEE237-ACF6-47F2-9C39-ED544222712E"), "02", "Mẹ đẻ", 2),
                new RelativeType(new Guid("1376A459-2ACD-42E2-A7A7-2591F74B21EB"), "03", "Bố nuôi", 3),
                new RelativeType(new Guid("BCABC031-806F-452A-84DA-77D554E5A5B4"), "04", "Mẹ nuôi", 4),
                new RelativeType(new Guid("4252AF04-6CFE-4476-BB99-4A922B6BC0AD"), "05", "Anh ruột", 5),
                new RelativeType(new Guid("A734DA32-8028-4210-BAE5-98BDA97961FF"), "06", "Chị ruột", 6),
                new RelativeType(new Guid("1DAEDD7E-7CA2-4FDB-9956-4FA4C7718A79"), "07", "Em ruột", 7),
                new RelativeType(new Guid("9F3E6FC7-EF22-4BA4-9E59-8CCA8B6CB195"), "08", "Ông", 8),
                new RelativeType(new Guid("3B8FBD78-7899-4B81-832A-DA090F149077"), "00", "Bà", 9),
                new RelativeType(new Guid("6A46D932-03D2-477B-BE50-1A5E791ECB94"), "10", "Vợ", 10),
                new RelativeType(new Guid("8E15B578-7302-4E88-97AA-0B956759EAEE"), "11", "Chồng", 11),
                new RelativeType(new Guid("A08C20C4-3E67-429F-A6C8-F32AEAEB3532"), "12", "Con", 12),
                new RelativeType(new Guid("826CFC0A-538B-4CB8-86CF-3F61B3C58A7F"), "99", "Khác", 99)
                );
        }
    }
}
