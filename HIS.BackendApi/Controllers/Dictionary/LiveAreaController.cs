using HIS.ApplicationService.Dictionaries.Provinces;
using HIS.ApplicationService.Dictionary.LiveAreas;
using HIS.ApplicationService.Dictionary.LiveAreas.Dto;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.Province;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HIS.BackendApi.Controllers.Dictionary
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiveAreaController : ControllerBase
    {
        private readonly ILiveAreaAppService _liveAreaAppService;

        public LiveAreaController(ILiveAreaAppService liveAreaAppService)
        {
            _liveAreaAppService = liveAreaAppService;
        }

        [HttpGet("GetAll")]
        public async Task<PagedResultDto<LiveAreaDto>> GetAll([FromQuery] GetAllLiveAreaInputDto input)
        {
            return await _liveAreaAppService.GetAll(input);
        }

        [HttpGet("GetById")]
        public async Task<ResultDto<LiveAreaDto>> GetById(Guid id)
        {
            return await _liveAreaAppService.GetById(id);
        }

        [HttpPost("CreateOrEdit")]
        public async Task<ResultDto<LiveAreaDto>> CreateOrEdit(LiveAreaDto input)
        {
            return await _liveAreaAppService.CreateOrEdit(input);
        }

        [HttpDelete("Delete")]
        public async Task<ResultDto<LiveAreaDto>> Delete(Guid id)
        {
            return await _liveAreaAppService.Delete(id);
        }
    }
}
