using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HIS.EntityFrameworkCore.Migrations
{
    /// <inheritdoc />
    public partial class Init8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE OR ALTER VIEW [dbo].[V_DServiceRequest]
AS 
SELECT Ser.[Id],
       Ser.ServiceRequestCode,
       Ser.RequestTime, -- ngày chỉ định (tạo phiếu)
       Ser.UseTime, -- ngày y lệnh
       Ser.StartTime, -- Ngày bắt đầu
       Ser.EndTime, -- Ngày kết thúc
       Ser.Barcode,
       Ser.NumOrder, -- số thứ tự chỉ định trong ngày (số thứ tự thực hiện)
       Ser.IsPriority, -- ưu tiên
       Ser.IcdCode, -- chẩn đoán
       Ser.IcdName, -- tên chẩn đoán
       Ser.IcdSubCode, -- bệnh kèm theo
       Ser.IcdText, -- danh sách bệnh kèm theo
       Ser.ServiceRequestTypeId, -- loại dịch vụ
       Ser.PatientRecordId,
       Ser.MedicalRecordId,
       Ser.TreatmentId,
       Ser.DepartmentId, -- khoa chỉ định
       Ser.RoomId, -- phòng chỉ định
       Ser.UserId, -- người chỉ định
       Ser.StartUserId, -- người bắt đầu thực hiện
       Ser.EndUserId, -- người kết thúc (trả kết quả)
       Ser.ExecuteDepartmentId, -- khoa thực hiện
       Ser.ExecuteRoomId, -- phòng thực hiện
       Ser.[Status], -- trạng thái
       
       US.Username UserCode,
       US.FullName UserName,
       Pat.Code PatientCode,
       Pat.[Name] PatientName,
       Dep.Code DepartmentCode,
       Dep.[Name] DepartmentName,
       Roo.Code RoomCode,
       Roo.[Name] RoomName,
       ExRo.Code ExecuteRoomCode,
       ExRo.[Name] ExecuteRoomName,
       SUS.Username StartUserCode,
       SUS.FullName StartUserName,
       EUS.Username EndUserCode,
       EUS.FullName EndUserName
FROM ServiceRequests AS Ser
INNER JOIN DPatientRecord AS Pat ON Ser.PatientRecordId = Pat.Id
LEFT JOIN SDepartment AS Dep ON Ser.DepartmentId = Dep.Id
LEFT JOIN SRoom AS Roo ON Ser.RoomId = Roo.Id
LEFT JOIN SRoom AS ExRo ON Ser.ExecuteRoomId = ExRo.Id
LEFT JOIN SUser AS US ON Ser.UserId = US.Id
LEFT JOIN SUser AS SUS ON Ser.StartUserId = SUS.Id
LEFT JOIN SUser AS EUS ON Ser.EndUserId = EUS.Id
GO");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
