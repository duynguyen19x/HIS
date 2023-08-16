using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDImpMest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InvNo",
                table: "DImpMests",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "DImpExpMestTypes",
                columns: new[] { "Id", "Code", "Inactive", "Name" },
                values: new object[,]
                {
                    { 1, "01", false, "Nhập hàng hóa từ nhà cung cấp" },
                    { 2, "02", false, "Xuất hàng hóa trả nhà cung cấp" },
                    { 3, "03", false, "Nhập từ kho khác" },
                    { 4, "04", false, "Xuất trả kho khác" },
                    { 5, "05", false, "Nhập bù" },
                    { 6, "06", false, "Xuất thanh lý" },
                    { 7, "07", false, "Xuất kiểm nghiệm" },
                    { 8, "08", false, "Xuất hủy (Mất, hỏng, vỡ)" },
                    { 9, "09", false, "Xuất hao phí phòng khám" },
                    { 10, "10", false, "Xuất sử dụng phòng" },
                    { 11, "11", false, "Xuất sử dụng khoa" },
                    { 12, "12", false, "Nhập bù cơ số tủ trực" },
                    { 13, "13", false, "Xuất bù cơ số tủ trực" },
                    { 14, "14", false, "Bổ sung cơ số tủ trực" },
                    { 15, "15", false, "Hoàn trả cơ số tủ trực" },
                    { 16, "16", false, "Xuất bản cho khách hàng" },
                    { 17, "17", false, "Nhập trả từ khách hàng" },
                    { 18, "18", false, "Xuất khác" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DImpExpMestTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DImpExpMestTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DImpExpMestTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DImpExpMestTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DImpExpMestTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DImpExpMestTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DImpExpMestTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DImpExpMestTypes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DImpExpMestTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DImpExpMestTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DImpExpMestTypes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DImpExpMestTypes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DImpExpMestTypes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DImpExpMestTypes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DImpExpMestTypes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DImpExpMestTypes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "DImpExpMestTypes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "DImpExpMestTypes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DropColumn(
                name: "InvNo",
                table: "DImpMests");
        }
    }
}
