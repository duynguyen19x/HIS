using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.EntityFrameworkCore.Configurations.Dictionary
{
    internal class HospitalLineConfig : IEntityTypeConfiguration<HospitalLine>
    {
        public void Configure(EntityTypeBuilder<HospitalLine> builder)
        {
            builder.HasData(
                new HospitalLine() { Id = new Guid("FBC4742B-AE6B-4A97-BAFF-769E89D14928"), HospitalLineCode = "TRUNG_UONG", HospitalLineName = "Tuyến trung ương", SortOrder = 1 },
                new HospitalLine() { Id = new Guid("690E1BFC-182A-4C34-BE21-11E31F49DD9A"), HospitalLineCode = "TINH", HospitalLineName = "Tuyến tỉnh", SortOrder = 2 },
                new HospitalLine() { Id = new Guid("684CD126-D475-4994-AAA6-858D45DB2DD3"), HospitalLineCode = "HUYEN", HospitalLineName = "Tuyến huyện", SortOrder = 3 },
                new HospitalLine() { Id = new Guid("07EA16B0-1B0B-4C5F-AE49-53A6BE1A0E62"), HospitalLineCode = "XA", HospitalLineName = "Tuyến xã", SortOrder = 4 },
                new HospitalLine() { Id = new Guid("38792889-79C3-4F8E-8EC5-CDD2648BDBA3"), HospitalLineCode = "PHONGKHAM", HospitalLineName = "Phòng khám", SortOrder = 5 }
                );
        }
    }
}
