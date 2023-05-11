using HIS.Dtos.Business.Patient;
using HIS.Dtos.Commons;
using HIS.EntityFrameworkCore.DbContexts;
using HIS.Models.Commons;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Patient
{
    public class SPatientService : BaseSerivce, ISPatientService
    {
        public SPatientService(HIS_DbContext dbContext, IConfiguration config)
            : base(dbContext, config)
        {

        }

        public Task<ApiResult<SPatientDto>> CreateOrEdit(SPatientDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<SPatientDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResultList<SPatientDto>> GetAll(GetAllSPatientInput input)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResult<SPatientDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
