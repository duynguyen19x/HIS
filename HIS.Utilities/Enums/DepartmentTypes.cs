using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Utilities.Enums
{
    public enum DepartmentTypes
    {
        [Description("Khoa lâm sàng")]
        ClinicalDepartment = 1,

        [Description("Khoa cận lâm sàng")]
        ClinicalLaboratoryDepartment = 2,

        [Description("Khoa dược")]
        PharmacyDepartment,

        [Description("Kế hoạch tổng hợp")]
        ComprehensivePlan
    }
}
