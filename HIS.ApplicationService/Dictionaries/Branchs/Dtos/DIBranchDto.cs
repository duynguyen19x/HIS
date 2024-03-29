﻿using HIS.Core.Services.Dto;

namespace HIS.Dtos.Dictionaries.Branchs
{
    public class DIBranchDto : EntityDto<Guid?>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string HeinMediOrgCode { get; set; } // mã khám chữa bệnh ban đầu
        public string HeinMediOrgAcceptCode { get; set; } // mã KCBBĐ đúng tuyến (ngăn cách bởi dấu ;)
        public string Level { get; set; } // hạng bệnh viện
        public string Type { get; set; } // loại bệnh viện
        public string Line { get; set; } // tuyến bệnh viện
        public string ParentOrganizationName { get; set; } // tên đơn vị quản lý (sở y tế/bộ y tế)
        public Guid? ProvinceId { get; set; }
        public Guid? DistrictId { get; set; }
        public Guid? WardId { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int? SortOrder { get; set; }
        public bool Inactive { get; set; }
    }
}
