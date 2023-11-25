﻿using HIS.Core.Entities;
using HIS.Core.Entities.Auditing;

namespace HIS.EntityFrameworkCore.Entities.Dictionaries
{
    /// <summary>
    /// Chi nhánh.
    /// </summary>
    public class Branch : AuditedEntity<Guid>
    {
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string HeinMediOrgCode { get; set; } // mã khám chữa bệnh ban đầu
        public string HeinMediOrgAcceptCode { get; set; } // mã KCBBĐ đúng tuyến (ngăn cách bởi dấu ;)
        public string Level { get; set; } // hạng bệnh viện
        public string Type { get; set; } // loại bệnh viện
        public string Line { get; set; } // tuyến bệnh viện
        public string ParentOrganizationName { get; set; } // tên đơn vị quản lý (sở y tế/bộ y tế)
        public Guid? ProvinceOrCityID { get; set; }
        public Guid? DistrictID { get; set; }
        public Guid? WardOrCommuneID { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int? SortOrder { get; set; }
        public bool Inactive { get; set; }
    }
}
