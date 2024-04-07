using HIS.ApplicationService.Dictionary.LiveAreas.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Dtos.Dictionaries.Ward;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionary.LiveAreas
{
    public interface ILiveAreaAppService : IAppService
    {
        Task<ResultDto<LiveAreaDto>> CreateOrEdit(LiveAreaDto input);

        Task<ResultDto<LiveAreaDto>> Delete(Guid id);

        Task<PagedResultDto<LiveAreaDto>> GetAll(GetAllLiveAreaInputDto input);

        Task<ResultDto<LiveAreaDto>> GetById(Guid id);
    }
}
