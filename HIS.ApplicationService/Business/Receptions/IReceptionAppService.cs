using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Business.Receptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Receptions
{
    public interface IReceptionAppService : IBaseAppService
    {
        Task<ResultDto<ReceptionDto>> CreateOrEdit(ReceptionDto input);
        Task<ResultDto<ReceptionDto>> Delete(Guid id);
        Task<PagedResultDto<ReceptionDto>> GetAll(ReceptionRequestDto input);
        Task<ResultDto<ReceptionDto>> GetById(Guid id);
    }
}
