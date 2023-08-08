using HIS.ApplicationService.Business.DImpExpMestType;
using HIS.Dtos.Business.DImMest;
using HIS.Dtos.Business.DImpExpMestType;
using HIS.Dtos.Commons;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Business.Pharmaceuticals
{
    [Route("api/[controller]")]
    [ApiController]
    public class DImpExpMestTypeController : ControllerBase
    {
        private readonly IDImpExpMestTypeService _dImpExpMestTypeService;

        public DImpExpMestTypeController(IDImpExpMestTypeService dImpExpMestTypeService)
        {
            _dImpExpMestTypeService = dImpExpMestTypeService;
        }

        [HttpGet("GetAll")]
        public async Task<ApiResultList<DImpExpMestTypeDto>> GetAll([FromQuery] GetAllDImpExpMestTypeInput input)
        {
            return await _dImpExpMestTypeService.GetAll(input);
        }
    }
}
