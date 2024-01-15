using HIS.ApplicationService.Dictionaries.Branchs;
using HIS.Dtos.Dictionaries.Branchs;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : BaseCrudController<IDIBranchAppService, BranchDto, Guid, GetAllBranchInput>
    {
        public BranchController(IDIBranchAppService appService) 
            : base(appService)
        {
        }
    }
}
