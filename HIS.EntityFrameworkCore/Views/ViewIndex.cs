using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace HIS.EntityFrameworkCore.Views
{
    public static class ViewIndex
    {
        public static void AddViews(this ModelBuilder builder)
        {
            builder.Entity<ServiceRequestView>()
                .ToView("V_BUS_ServiceRequest")
                .ToSqlQuery(@"/****** Object:  View [dbo].[V_BUS_ServiceRequest]    Script Date: 23/12/2023 12:58:03 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[V_BUS_ServiceRequest]'))
DROP VIEW [dbo].[V_BUS_ServiceRequest]
GO
/****** Object:  View [dbo].[V_BUS_ServiceRequest]    Script Date: 23/12/2023 12:58:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[V_BUS_ServiceRequest]
AS 
SELECT Ser.[Id]
      ,Ser.[ServiceRequestCode]
      ,Ser.[ServiceRequestDate]
      ,Ser.[ServiceRequestUseDate]
      ,Ser.[Barcode]
      ,Ser.[NumOrder]
      ,Ser.[IsPriority]
      ,Ser.[IcdCode]
      ,Ser.[IcdName]
      ,Ser.[IcdSubCode]
      ,Ser.[IcdText]
      ,Ser.[ServiceRequestTypeId]
      ,Ser.[ServiceRequestStatusId]
      ,Ser.[PatientRecordId]
      ,Ser.[MedicalRecordId]
      ,Ser.[TreatmentId]
      ,Ser.[DepartmentId]
      ,Ser.[RoomId]
      ,Ser.[UserId]
      ,Ser.[ExecuteDepartmentId]
      ,Ser.[ExecuteRoomId]
      ,Ser.[ExecuteUserId]
      ,Ser.[CreatedDate]
      ,Ser.[CreatedBy]
      ,Ser.[ModifiedDate]
      ,Ser.[ModifiedBy]
      ,Ser.[DeletedDate]
      ,Ser.[DeletedBy]
      ,Ser.[IsDeleted]
	  ,Pat.PatientName
	  ,Pat.PatientRecordCode AS PatientCode
	  ,Dep.[Code] AS DepartmentCode
	  ,Dep.[Name] AS DepartmentName
	  ,Roo.[Code] AS RoomCode
	  ,Roo.[Name] AS RoomName
	  ,ExRo.[Code] AS ExecuteRoomCode
	  ,ExRo.[Name] AS ExecuteRoomName
	  ,US.[UserName] AS ExecuteUserCode
	  ,US.[FirstName] AS ExecuteUserName
FROM BUS_ServiceRequest AS Ser
INNER JOIN BUS_PatientRecord AS Pat ON Ser.PatientRecordId = Pat.Id
LEFT JOIN DIC_Department AS Dep ON Ser.DepartmentId = Dep.Id
LEFT JOIN DIC_Room AS Roo ON Ser.RoomId = Roo.Id
LEFT JOIN DIC_Room AS ExRo ON Ser.ExecuteRoomId = ExRo.Id
LEFT JOIN SYS_User AS US ON Ser.ExecuteUserId = US.Id
GO
");
        }
    }
}
