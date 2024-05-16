using HIS.ApplicationService.Business.Receptions.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.EntityFrameworkCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Receptions
{
    public interface IReceptionAppService : IAppService
    {
        Task<ResultDto<ReceptionDto>> Get(Guid id);
        Task<PagedResultDto<ReceptionDto>> GetAll(GetAllReceptionInputDto input);
        Task<ResultDto<ReceptionDto>> CreateOrEdit(ReceptionDto input);
        Task<ResultDto<ReceptionDto>> Delete(Guid id);
    }
}
