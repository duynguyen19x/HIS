using HIS.Core.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities.Business
{
    /// <summary>
    /// Phiếu thu, chi.
    /// </summary>
    public class Transaction : FullAuditedEntity<Guid>
    {
        public virtual string Code { get; set; } // số phiếu
        public virtual DateTime TransactionTime { get; set; } // thời gian thu, chi
        public virtual int TransactionTypeId { get; set; } // loại thu chi
        public virtual int PaymentMethodId { get; set; } // phướng thức thanh toán
        public virtual Guid AccountBookId { get; set; } // sổ thu, chi
        public virtual decimal Amount { get; set; } // số tiền phỉa thu, chi
        public virtual decimal DiscountRate { get; set; } // % chiết khấu
        public virtual decimal DiscountAmount { get; set; } // số tiền chiết khấu
        public virtual string DiscountReason { get; set; } // lý do chiết khấu

        public virtual Guid UserId { get; set; } // người tạo (thu ngân)
        public virtual Guid DepartmentId { get; set; } // khoa bệnh nhân đang khám, điều trị tại thời điểm thu, chi
        public virtual Guid RoomId { get; set; } // phòng bệnh nhân đang khám, điều trị tại thời điểm thu, chi

        public virtual Guid PatientRecordId { get; set; } // mã điều trị
        public virtual Guid MedicalRecordId { get; set; } // mã bệnh án
        public virtual Guid TreatmentId { get; set; } // mã tờ điều trị
        public virtual int PatientTypeId { get; set; } // đối tượng
        public virtual int PatientRecordTypeId { get; set; } // loại điều trị

        public virtual bool IsCancel { get; set; } // hủy phiếu
        public virtual DateTime? CancelTime { get; set; } // thời gian hủy phiếu
        public virtual Guid? CancelUserId { get; set; } // người hủy phiếu
        public virtual string CancelReason { get; set; } // lý do hủy

        public virtual int PrintCount { get; set; } // số lần đã in
        public virtual int SortOrder { get; set; } // thứ tụ hiển thị
        public virtual string Description { get; set; } // ghi chú
        public virtual bool Inactive { get; set; }


        public Transaction() { }
    }
}
