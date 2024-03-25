using HIS.ApplicationService.Dictionary.Services.Dto;
using HIS.Core.Application.Services.Dto;

namespace HIS.ApplicationService.Dictionary.SurgicalProcedureTypes.Dto
{
    public class SSurgicalProcedureTypeDto : EntityDto<int?>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int? SortOrder { get; set; }

        public IList<ServiceDto> SServices { get; set; }
    }
}
