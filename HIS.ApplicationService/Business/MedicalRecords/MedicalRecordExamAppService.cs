using AutoMapper;
using HIS.Application.Core.Services;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
