using HIS.Core.Services.Dto;
using HIS.ApplicationService.Dictionaries.Genders;
using HIS.Dtos.Dictionaries.Genders;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionaries
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenderController : BaseCrudController<IGenderAppService, GenderDto, Guid?, GetAllGenderInput>
    {
        public GenderController(IGenderAppService appService) 
            : base(appService)
        {
        }
    }
}
