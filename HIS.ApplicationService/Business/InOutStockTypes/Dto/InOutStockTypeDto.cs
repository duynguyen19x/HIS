using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Business.InOutStockTypes.Dto
{
    public class InOutStockTypeDto : EntityDto<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Inactive { get; set; }
    }
}
