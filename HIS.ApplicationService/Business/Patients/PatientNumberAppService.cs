using HIS.ApplicationService.Business.Patients.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.EntityFrameworkCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace HIS.ApplicationService.Business.Patients
{
    public class PatientNumberAppService : BaseAppService, IPatientNumberAppService
    {
        private readonly IRepository<PatientNumber, Guid> _patientNumberRepository;

        public PatientNumberAppService(IRepository<PatientNumber, Guid> patientNumberRepository) 
        {
            _patientNumberRepository = patientNumberRepository;
        }

        public async Task<ResultDto<PatientNumberDto>> CreateLastNumber(DateTime patientNumberDate)
        {
            var result = new ResultDto<PatientNumberDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var lastOrderInYear = _patientNumberRepository.GetAll()
                        .Where(x => x.PatientNumberDate.Year == patientNumberDate.Year)
                        .Select(s => s.NumOrder)
                        .DefaultIfEmpty()
                        .Max();
                        
                    var patientNumber = new PatientNumber();
                    patientNumber.Id = Guid.NewGuid();
                    patientNumber.PatientNumberDate = patientNumberDate;
                    patientNumber.NumOrder = lastOrderInYear + 1;
                    await _patientNumberRepository.InsertAsync(patientNumber);

                    unitOfWork.Complete();
                    result.Success(ObjectMapper.Map<PatientNumberDto>(patientNumber));
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }
    }
}
