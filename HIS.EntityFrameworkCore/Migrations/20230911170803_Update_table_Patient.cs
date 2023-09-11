using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Update_table_Patient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BloodTypeId",
                table: "Patients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BloodRhId",
                table: "Patients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "DeathCauses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "DeathCauses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "DeathCauses",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "DeathWithins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "DeathWithins",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "DeathWithins",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "DeathWithins",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4521));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4524));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "PatientRecordTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "PatientRecordTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "PatientRecordTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "PatientTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "PatientTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "PatientTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "ReceptionType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "ReceptionType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 12, 0, 8, 2, 59, DateTimeKind.Local).AddTicks(4358));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BloodTypeId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BloodRhId",
                table: "Patients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "DeathCauses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "DeathCauses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "DeathCauses",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "DeathWithins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "DeathWithins",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "DeathWithins",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "DeathWithins",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "PatientRecordTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "PatientRecordTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "PatientRecordTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "PatientTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "PatientTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "PatientTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "ReceptionType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "ReceptionType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 9, 10, 10, 15, 29, 346, DateTimeKind.Local).AddTicks(5735));
        }
    }
}
