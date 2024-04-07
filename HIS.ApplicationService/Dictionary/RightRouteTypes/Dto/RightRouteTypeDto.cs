using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.RightRouteTypes.Dto
{
    /// <summary>
    /// Tuyến KCB
    /// </summary>
    public class RightRouteTypeDto : EntityDto<int>
    {
        public virtual string Code { get; set; }

        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual int SortOrder { get; set; }

        public virtual bool Inactive { get; set; }
    }
}
