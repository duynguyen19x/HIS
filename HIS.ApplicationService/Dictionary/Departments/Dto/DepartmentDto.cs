using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.Departments.Dto
{
    public class DepartmentDto : EntityDto<Guid?>
    {
        public virtual string Code { get; set; }

        public virtual string Name { get; set; }

        public virtual string MediCode { get; set; }

        public virtual int DepartmentTypeId { get; set; }

        public virtual string DepartmentTypeCode { get; set; }

        public virtual string DepartmentTypeName { get; set; }

        public Guid? BranchId { get; set; }

        public string BranchCode { get; set; }

        public string BranchName { get; set; }

        public virtual Guid? ChiefId { get; set; }

        public virtual string ChiefName { get; set; }

        public virtual string Tel { get; set; }

        public virtual string Email { get; set; }

        public virtual string Description { get; set; }

        public virtual int SortOrder { get; set; }

        public virtual bool Inactive { get; set; }
    }
}
