using AutoMapper;
using HIS.Application.Core.Services;
using HIS.EntityFrameworkCore;

namespace HIS.ApplicationService.Business.MedicalRecords
{
    public class MedicalRecordExamAppService : BaseAppService, IMedicalRecordExamAppService
    {
        public MedicalRecordExamAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }
    }
}
