using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Add_Table_Hospital_Icd_Job : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "SBranchs");

            migrationBuilder.AddColumn<string>(
                name: "MohCode",
                table: "SRooms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoomTypeId",
                table: "SRooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MohCode",
                table: "SDepartments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SHospitals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MohCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Line = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SHospitals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SIcds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MohReportCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameEnglish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameCommon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChapterCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChapterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChapterNameEnglish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainGroupCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainGroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainGroupNameEnglish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubGroup1Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubGroup1Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubGroup1NameEnglish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubGroup2Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubGroup2Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubGroup2NameEnglish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeNameEnglish = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIcds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SJobs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SJobs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SHospitals");

            migrationBuilder.DropTable(
                name: "SIcds");

            migrationBuilder.DropTable(
                name: "SJobs");

            migrationBuilder.DropColumn(
                name: "MohCode",
                table: "SRooms");

            migrationBuilder.DropColumn(
                name: "RoomTypeId",
                table: "SRooms");

            migrationBuilder.DropColumn(
                name: "MohCode",
                table: "SDepartments");

            migrationBuilder.AddColumn<Guid>(
                name: "ParentId",
                table: "SBranchs",
                type: "uniqueidentifier",
                nullable: true);
        }
    }
}
