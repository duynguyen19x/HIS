using HIS.Core.Domain.Entities.Auditing;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HIS.EntityFrameworkCore.Entities
{
    /// <summary>
    /// Dịch vụ được chỉ định
    /// </summary>
    [Table("DServiceRequest")]
    public class ServiceRequest : AuditedEntity<Guid>
    {
        public DateTime ServiceRequestDate { get; set; }
        public DateTime? ServiceRequestSampleDate { get; set; }
        public DateTime? ServiceRequestStartDate { get; set; }
        public DateTime? ServiceRequestEndDate { get; set; }
        public int ServiceRequestTypeID { get; set; }
        public int ServiceRequestStatusID { get; set; }
        public Guid PatientID { get; set; }
        public Guid MedicalRecordID { get; set; }
        public Guid TreatmentID { get; set; }
        public Guid OrderID { get; set; }
        public Guid ServiceID { get; set; }
        public string ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public string ServiceCodeBHYT { get; set; }
        public string ServiceNameBHYT { get; set; }
        public Guid UnitID { get; set; }
        public string UnitCode { get; set; }
        public string UnitName { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public decimal Amount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxAmount { get; set; }

        public string DataUnit { get; set; } // đơn vị tính
        public string DataValue { get; set; }
        public string DataReference { get; set; }
        public string DataValueLowHight { get; set; }

        public int ServiceRequestObjectID { get; set; }
        public int PatientObjectTypeID { get; set; }
        public Guid InsuranceID { get; set; }
        public Guid BranchID { get; set; }
        public Guid DepartmentID { get; set; }
        public Guid RoomID { get; set; }
        public Guid UserID { get; set; }
        public Guid? SampleDepartmentID { get; set; }
        public Guid? SampleRoomID { get; set; }
        public Guid? SampleUserID { get; set; }
        public Guid? ExecuteDepartmentID { get; set; }
        public Guid? ExecuteRoomID { get; set; }
        public Guid? ExecuteUserID { get; set; }
        public Guid? ParentID { get; set; }
        public int SortOrder { get; set; }
        public string Description { get; set; }

        [ForeignKey(nameof(PatientID))]
        public virtual Patient PatientFK { get; set; }

        [ForeignKey(nameof(MedicalRecordID))]
        public virtual MedicalRecord MedicalRecordFK { get; set; }

        [ForeignKey(nameof(TreatmentID))]
        public virtual Treatment TreatmentFK { get; set; }

        [ForeignKey(nameof(OrderID))]
        public virtual Order OrderFK { get; set; }

        [ForeignKey(nameof(ServiceID))]
        public virtual Service ServiceFK { get; set; }

        [ForeignKey(nameof(BranchID))]
        public virtual Branch BranchFK { get; set; }

        [ForeignKey(nameof(DepartmentID))]
        public virtual Department DepartmentFK { get; set; }

        [ForeignKey(nameof(RoomID))]
        public virtual Room RoomFK { get; set; }

        [ForeignKey(nameof(UserID))]
        public virtual User UserFK { get; set; }
    }
}
