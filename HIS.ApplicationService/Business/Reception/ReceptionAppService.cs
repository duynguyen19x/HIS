using HIS.ApplicationService.Business.PatientRecords.Dto;
using HIS.ApplicationService.Business.Reception.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities.Business;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Reception
{
    /// <summary>
    /// Phòng tiếp đón.
    /// </summary>
    public class ReceptionAppService : BaseAppService, IReceptionAppService
    {
        private readonly IRepository<Patient, Guid> _patientRepository;
        private readonly IRepository<PatientRecord, Guid> _patientRecordRepository;
        private readonly IRepository<MedicalRecord, Guid> _medicalRecordRepository;

        public ReceptionAppService(
            IRepository<Patient, Guid> patientRepository,
            IRepository<PatientRecord, Guid> patientRecordRepository,
            IRepository<MedicalRecord, Guid> medicalRecordRepository) 
        {
            _patientRepository = patientRepository;
            _patientRecordRepository = patientRecordRepository;
            _medicalRecordRepository = medicalRecordRepository;
        }

        public async Task<PagedResultDto<ReceptionDto>> GetAll(GetAllReceptionInputDto input)
        {
            var patientRecordFilter = _patientRecordRepository.GetAll();


            return null;
        }

        public async Task<ResultDto> CreateOrUpdateAsync(PatientRecordDto input)
        {
            if (Check.IsNullOrDefault(input.Id))
            {
                return await CreateAsync(input);
            }
            else
            {
                return await UpdateAsync(input);
            }
        }

        public async Task<ResultDto> CreateAsync(PatientRecordDto input)
        {
            return null;
        }

        public async Task<ResultDto> UpdateAsync(PatientRecordDto input)
        {
            return null;
        }

        public async Task<ResultDto> DeleteAsync(Guid id)
        {
            return null;
        }
    }
}
