using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Update_table_ServiceRequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InOutStocks_PatientRecords_PatientRecordId",
                table: "InOutStocks");

            migrationBuilder.DropForeignKey(
                name: "FK_InOutStocks_Patients_PatientId",
                table: "InOutStocks");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalRecords_Branchs_BranchID",
                table: "MedicalRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalRecords_Departments_DepartmentID",
                table: "MedicalRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalRecords_PatientRecords_PatientRecordID",
                table: "MedicalRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalRecords_Rooms_RoomID",
                table: "MedicalRecords");

            migrationBuilder.DropTable(
                name: "ServiceRequestDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceRequests",
                table: "ServiceRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patients",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PatientRecords",
                table: "PatientRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalRecords",
                table: "MedicalRecords");

            migrationBuilder.RenameTable(
                name: "ServiceRequests",
                newName: "ServiceRequest");

            migrationBuilder.RenameTable(
                name: "Patients",
                newName: "Patient");

            migrationBuilder.RenameTable(
                name: "PatientRecords",
                newName: "PatientRecord");

            migrationBuilder.RenameTable(
                name: "MedicalRecords",
                newName: "MedicalRecord");

            migrationBuilder.RenameColumn(
                name: "TreatmentID",
                table: "ServiceRequest",
                newName: "TreatmentId");

            migrationBuilder.RenameColumn(
                name: "RequestRoomID",
                table: "ServiceRequest",
                newName: "RequestRoomId");

            migrationBuilder.RenameColumn(
                name: "RequestDepartmentID",
                table: "ServiceRequest",
                newName: "RequestDepartmentId");

            migrationBuilder.RenameColumn(
                name: "PatientRecordID",
                table: "ServiceRequest",
                newName: "PatientRecordId");

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "ServiceRequest",
                newName: "PatientId");

            migrationBuilder.RenameColumn(
                name: "MedicalRecordID",
                table: "ServiceRequest",
                newName: "MedicalRecordId");

            migrationBuilder.RenameColumn(
                name: "ExecuteRoomID",
                table: "ServiceRequest",
                newName: "ExecuteRoomId");

            migrationBuilder.RenameColumn(
                name: "ExecuteDepartmentID",
                table: "ServiceRequest",
                newName: "ExecuteDepartmentId");

            migrationBuilder.RenameColumn(
                name: "BranchID",
                table: "ServiceRequest",
                newName: "BranchId");

            migrationBuilder.RenameColumn(
                name: "ExecuteTime",
                table: "ServiceRequest",
                newName: "ExecuteStartTime");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalRecords_RoomID",
                table: "MedicalRecord",
                newName: "IX_MedicalRecord_RoomID");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalRecords_PatientRecordID",
                table: "MedicalRecord",
                newName: "IX_MedicalRecord_PatientRecordID");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalRecords_DepartmentID",
                table: "MedicalRecord",
                newName: "IX_MedicalRecord_DepartmentID");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalRecords_BranchID",
                table: "MedicalRecord",
                newName: "IX_MedicalRecord_BranchID");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ServiceRequest",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "ServiceRequest",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Barcode",
                table: "ServiceRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExecuteEndTime",
                table: "ServiceRequest",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ExecuteUserId",
                table: "ServiceRequest",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExecuteUsername",
                table: "ServiceRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IcdCauseCode",
                table: "ServiceRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IcdCauseName",
                table: "ServiceRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IcdCode",
                table: "ServiceRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IcdName",
                table: "ServiceRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IcdSubCode",
                table: "ServiceRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IcdSubName",
                table: "ServiceRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IcdText",
                table: "ServiceRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsEmergency",
                table: "ServiceRequest",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPriority",
                table: "ServiceRequest",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "RequestUserId",
                table: "ServiceRequest",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "RequestUsername",
                table: "ServiceRequest",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SampleRoomId",
                table: "ServiceRequest",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "ServiceRequest",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceRequest",
                table: "ServiceRequest",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patient",
                table: "Patient",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PatientRecord",
                table: "PatientRecord",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicalRecord",
                table: "MedicalRecord",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ServiceRequestServe",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ServiceCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRequestServe", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "DeathCauses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DeathCauses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DeathCauses",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DeathWithins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DeathWithins",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DeathWithins",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DeathWithins",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MedicalRecordEndTypes",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "MedicalRecordResults",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PatientRecordTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PatientRecordTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PatientRecordTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PatientTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PatientTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PatientTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ReceptionType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "ReceptionType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(1975, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_InOutStocks_PatientRecord_PatientRecordId",
                table: "InOutStocks",
                column: "PatientRecordId",
                principalTable: "PatientRecord",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InOutStocks_Patient_PatientId",
                table: "InOutStocks",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalRecord_Branchs_BranchID",
                table: "MedicalRecord",
                column: "BranchID",
                principalTable: "Branchs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalRecord_Departments_DepartmentID",
                table: "MedicalRecord",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalRecord_PatientRecord_PatientRecordID",
                table: "MedicalRecord",
                column: "PatientRecordID",
                principalTable: "PatientRecord",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalRecord_Rooms_RoomID",
                table: "MedicalRecord",
                column: "RoomID",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InOutStocks_PatientRecord_PatientRecordId",
                table: "InOutStocks");

            migrationBuilder.DropForeignKey(
                name: "FK_InOutStocks_Patient_PatientId",
                table: "InOutStocks");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalRecord_Branchs_BranchID",
                table: "MedicalRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalRecord_Departments_DepartmentID",
                table: "MedicalRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalRecord_PatientRecord_PatientRecordID",
                table: "MedicalRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicalRecord_Rooms_RoomID",
                table: "MedicalRecord");

            migrationBuilder.DropTable(
                name: "ServiceRequestServe");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServiceRequest",
                table: "ServiceRequest");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PatientRecord",
                table: "PatientRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patient",
                table: "Patient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MedicalRecord",
                table: "MedicalRecord");

            migrationBuilder.DropColumn(
                name: "Barcode",
                table: "ServiceRequest");

            migrationBuilder.DropColumn(
                name: "ExecuteEndTime",
                table: "ServiceRequest");

            migrationBuilder.DropColumn(
                name: "ExecuteUserId",
                table: "ServiceRequest");

            migrationBuilder.DropColumn(
                name: "ExecuteUsername",
                table: "ServiceRequest");

            migrationBuilder.DropColumn(
                name: "IcdCauseCode",
                table: "ServiceRequest");

            migrationBuilder.DropColumn(
                name: "IcdCauseName",
                table: "ServiceRequest");

            migrationBuilder.DropColumn(
                name: "IcdCode",
                table: "ServiceRequest");

            migrationBuilder.DropColumn(
                name: "IcdName",
                table: "ServiceRequest");

            migrationBuilder.DropColumn(
                name: "IcdSubCode",
                table: "ServiceRequest");

            migrationBuilder.DropColumn(
                name: "IcdSubName",
                table: "ServiceRequest");

            migrationBuilder.DropColumn(
                name: "IcdText",
                table: "ServiceRequest");

            migrationBuilder.DropColumn(
                name: "IsEmergency",
                table: "ServiceRequest");

            migrationBuilder.DropColumn(
                name: "IsPriority",
                table: "ServiceRequest");

            migrationBuilder.DropColumn(
                name: "RequestUserId",
                table: "ServiceRequest");

            migrationBuilder.DropColumn(
                name: "RequestUsername",
                table: "ServiceRequest");

            migrationBuilder.DropColumn(
                name: "SampleRoomId",
                table: "ServiceRequest");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "ServiceRequest");

            migrationBuilder.RenameTable(
                name: "ServiceRequest",
                newName: "ServiceRequests");

            migrationBuilder.RenameTable(
                name: "PatientRecord",
                newName: "PatientRecords");

            migrationBuilder.RenameTable(
                name: "Patient",
                newName: "Patients");

            migrationBuilder.RenameTable(
                name: "MedicalRecord",
                newName: "MedicalRecords");

            migrationBuilder.RenameColumn(
                name: "TreatmentId",
                table: "ServiceRequests",
                newName: "TreatmentID");

            migrationBuilder.RenameColumn(
                name: "RequestRoomId",
                table: "ServiceRequests",
                newName: "RequestRoomID");

            migrationBuilder.RenameColumn(
                name: "RequestDepartmentId",
                table: "ServiceRequests",
                newName: "RequestDepartmentID");

            migrationBuilder.RenameColumn(
                name: "PatientRecordId",
                table: "ServiceRequests",
                newName: "PatientRecordID");

            migrationBuilder.RenameColumn(
                name: "PatientId",
                table: "ServiceRequests",
                newName: "PatientID");

            migrationBuilder.RenameColumn(
                name: "MedicalRecordId",
                table: "ServiceRequests",
                newName: "MedicalRecordID");

            migrationBuilder.RenameColumn(
                name: "ExecuteRoomId",
                table: "ServiceRequests",
                newName: "ExecuteRoomID");

            migrationBuilder.RenameColumn(
                name: "ExecuteDepartmentId",
                table: "ServiceRequests",
                newName: "ExecuteDepartmentID");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "ServiceRequests",
                newName: "BranchID");

            migrationBuilder.RenameColumn(
                name: "ExecuteStartTime",
                table: "ServiceRequests",
                newName: "ExecuteTime");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalRecord_RoomID",
                table: "MedicalRecords",
                newName: "IX_MedicalRecords_RoomID");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalRecord_PatientRecordID",
                table: "MedicalRecords",
                newName: "IX_MedicalRecords_PatientRecordID");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalRecord_DepartmentID",
                table: "MedicalRecords",
                newName: "IX_MedicalRecords_DepartmentID");

            migrationBuilder.RenameIndex(
                name: "IX_MedicalRecord_BranchID",
                table: "MedicalRecords",
                newName: "IX_MedicalRecords_BranchID");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ServiceRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "ServiceRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServiceRequests",
                table: "ServiceRequests",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PatientRecords",
                table: "PatientRecords",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patients",
                table: "Patients",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MedicalRecords",
                table: "MedicalRecords",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ServiceRequestDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ServiceID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceRequestDetails", x => x.Id);
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_InOutStocks_PatientRecords_PatientRecordId",
                table: "InOutStocks",
                column: "PatientRecordId",
                principalTable: "PatientRecords",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InOutStocks_Patients_PatientId",
                table: "InOutStocks",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalRecords_Branchs_BranchID",
                table: "MedicalRecords",
                column: "BranchID",
                principalTable: "Branchs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalRecords_Departments_DepartmentID",
                table: "MedicalRecords",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalRecords_PatientRecords_PatientRecordID",
                table: "MedicalRecords",
                column: "PatientRecordID",
                principalTable: "PatientRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalRecords_Rooms_RoomID",
                table: "MedicalRecords",
                column: "RoomID",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
