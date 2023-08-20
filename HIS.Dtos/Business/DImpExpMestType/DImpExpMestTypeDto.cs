using HIS.Application.Core.Services.Dto;

namespace HIS.Dtos.Business.DImpExpMestType
{
    public class DImpExpMestTypeDto : EntityDto<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Inactive { get; set; }
    }
}
