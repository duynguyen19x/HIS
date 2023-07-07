using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Dtos.Dictionaries.Department
{
    public class SDepartmentDto
    {
        public Guid? Id { get; set; }
        public string Code { get; set; }
        public string MohCode { get; set; }
        public string Name { get; set; }
        public int? DepartmentTypeId { get; set; }
        public string DepartmentTypeCode { get; set; }
        public string DepartmentTypeName { get; set; }
        public Guid? BranchId { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string Description { get; set; }
        public int? SortOrder { get; set; }
        public bool Inactive { get; set; }
    }
}
