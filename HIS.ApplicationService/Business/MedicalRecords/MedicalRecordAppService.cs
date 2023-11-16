using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Dtos.Business.MedicalRecords;
using HIS.EntityFrameworkCore;

namespace HIS.ApplicationService.Business.MedicalRecords
{
    public class MedicalRecordAppService : BaseAppService, IMedicalRecordAppService
    {
        public MedicalRecordAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public Task<ResultDto<MedicalRecordDto>> CreateOrEdit(MedicalRecordDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<MedicalRecordDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<MedicalRecordDto>> GetAll(PagedMedicalRecordInputDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<MedicalRecordDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
