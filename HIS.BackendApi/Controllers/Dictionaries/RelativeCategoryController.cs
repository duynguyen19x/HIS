using HIS.ApplicationService.Dictionaries.RelativeCategories;
using HIS.Dtos.Dictionaries.RelativeCategories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class RelativeCategoryController : BaseCrudController<IRelativeCategoryAppService, RelativeCategoryDto, Guid, GetAllRelativeCategoryInput>
    {
        public RelativeCategoryController(IRelativeCategoryAppService appService) 
            : base(appService)
        {
        }
    }
}
