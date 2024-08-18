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
    public class OrderTypeConfig : IEntityTypeConfiguration<OrderType>
    {
        public void Configure(EntityTypeBuilder<OrderType> builder)
        {
            builder.HasData(
                new OrderType(01, "KB", "Phiếu Khám Bệnh", new DateTime(2024, 1, 1)),
                new OrderType(02, "KBKH", "Phiếu Khám Bệnh Kết Hợp", new DateTime(2024, 1, 1)),
                new OrderType(03, "DTKH", "Phiếu Điều Trị Kết Hợp", new DateTime(2024, 1, 1)),
                new OrderType(04, "XN", "Phiếu Xét Nghiệm", new DateTime(2024, 1, 1)),
                new OrderType(05, "HA", "Phiếu Chẩn Đoán Hình Ảnh", new DateTime(2024, 1, 1)),
                new OrderType(06, "PT", "Phẫu thuật", new DateTime(2024, 1, 1)),
                new OrderType(07, "CK", "Phiếu Chuyên khoa", new DateTime(2024, 1, 1)),
                new OrderType(08, "DV", "Dịch vụ khác", new DateTime(2024, 1, 1)),
                new OrderType(09, "TH", "Đơn Thuốc", new DateTime(2024, 1, 1)),
                new OrderType(10, "VT", "Phiếu Vật tư", new DateTime(2024, 1, 1)),
                new OrderType(11, "MAU", "Máu", new DateTime(2024, 1, 1)),
                new OrderType(12, "AV", "Áo vàng", new DateTime(2024, 1, 1)),
                new OrderType(13, "SA", "Suất ăn", new DateTime(2024, 1, 1)),
                new OrderType(14, "NC", "Nợ cũ", new DateTime(2024, 1, 1)),
                new OrderType(15, "TIEM_CHUNG", "Phiếu Tiêm Chủng", new DateTime(2024, 1, 1)),
                new OrderType(16, "HH", "Hàng hóa", new DateTime(2024, 1, 1)),
                new OrderType(1004, "TH_XN", "Thực hiện xét nghiệm", new DateTime(2024, 1, 1)),
                new OrderType(1005, "TH_HA", "Thực hiện chẩn đoán hình ảnh", new DateTime(2024, 1, 1)),
                new OrderType(1006, "TH_PT", "Thực hiện phẫu thuật", new DateTime(2024, 1, 1)),
                new OrderType(1007, "TH_CK", "Thực hiện chuyên khoa", new DateTime(2024, 1, 1)),
                new OrderType(1012, "TH_SA", "Tổng hợp suất ăn", new DateTime(2024, 1, 1))
                );
        }
    }
}
