using HIS.ApplicationService.Business.MedicalRecords.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.MedicalRecords
{
    public class MedicalRecordAppService : BaseAppService, IMedicalRecordAppService
    {
        private readonly IRepository<MedicalRecord, Guid> _medicalRecordRepository;


        public MedicalRecordAppService(IRepository<MedicalRecord, Guid> medicalRecordRepository) 
        {
            _medicalRecordRepository = medicalRecordRepository;
        }

        public async Task<ResultDto<MedicalRecordDto>> CreateOrEdit(MedicalRecordDto input)
        {
            if (Check.IsNullOrDefault(input.Id))
            {
                return await Create(input);
            }    
            else
            {
                return await Update(input);
            }    
        }

        public Task<ResultDto<MedicalRecordDto>> Create(MedicalRecordDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<MedicalRecordDto>> Update(MedicalRecordDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<MedicalRecordDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultDto<MedicalRecordDto>> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<MedicalRecordDto>> GetAll(GetAllMedicalRecordInputDto input)
        {
            throw new NotImplementedException();
        }
    }
}
