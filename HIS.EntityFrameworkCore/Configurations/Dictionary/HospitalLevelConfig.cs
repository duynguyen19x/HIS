using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HIS.EntityFrameworkCore.Configurations.Dictionary
{
    public class HospitalLevelConfig : IEntityTypeConfiguration<HospitalLevel>
    {
        public void Configure(EntityTypeBuilder<HospitalLevel> builder)
        {
            builder.HasData(
                new HospitalLevel() { CreatedDate = new DateTime(2024, 1, 1),  Id = new Guid("8F369537-85CF-493C-B525-DC84CDCA4B85"), HospitalLevelCode = "DAC_BIET", HospitalLevelName = "BV Hạng Đặc Biệt", SortOrder = 1 },
                new HospitalLevel() { CreatedDate = new DateTime(2024, 1, 1),  Id = new Guid("D8BDEC49-23DE-49F1-A7D6-4B29AF7AA81C"), HospitalLevelCode = "HANG_1", HospitalLevelName = "BV Hạng 1", SortOrder = 2 },
                new HospitalLevel() { CreatedDate = new DateTime(2024, 1, 1),  Id = new Guid("45E9DCE3-493F-47F0-96FE-752FF14A801B"), HospitalLevelCode = "HANG_2", HospitalLevelName = "BV Hạng 2", SortOrder = 3 },
                new HospitalLevel() { CreatedDate = new DateTime(2024, 1, 1),  Id = new Guid("8B85B2A9-6831-4EB8-8524-58F2541244B8"), HospitalLevelCode = "HANG_3", HospitalLevelName = "BV Hạng 3", SortOrder = 4 },
                new HospitalLevel() { CreatedDate = new DateTime(2024, 1, 1), Id = new Guid("AE68EB6C-2E65-4561-80BE-74FC4E1B7BE2"), HospitalLevelCode = "HANG_4", HospitalLevelName = "BV Hạng 4", SortOrder = 5 }
                );
        }
    }
}
