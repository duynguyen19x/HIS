using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Business.Receptions;
using HIS.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Receptions
{
    /// <summary>
    /// Đăng ký khám.
    /// </summary>
    public class ReceptionAppService : BaseCrudAppService<ReceptionDto, Guid, GetAllReceptionInput>, IReceptionAppService
    {
        public ReceptionAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async override Task<ResultDto<ReceptionDto>> Create(ReceptionDto input)
        {
            var result = new ResultDto<ReceptionDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {

                    await SaveChangesAsync();
                    await transaction.CommitAsync();

                    result.IsSucceeded = true;
                    result.Item = input;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public override Task<ResultDto<ReceptionDto>> Update(ReceptionDto input)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<ReceptionDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public override Task<PagedResultDto<ReceptionDto>> GetAll(GetAllReceptionInput input)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<ReceptionDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        
    }
}
