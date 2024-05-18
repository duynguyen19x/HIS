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
    public class PatientOrderAppService : BaseAppService, IPatientOrderAppService
    {
        private readonly IRepository<PatientNumber, Guid> _patientOrderRepository;

        public PatientOrderAppService(IRepository<PatientNumber, Guid> patientOrderRepository) 
        {
            _patientOrderRepository = patientOrderRepository;
        }

        public async Task<ResultDto<PatientNumberDto>> CreateLastOrder(DateTime patientOrderDate)
        {
            var result = new ResultDto<PatientNumberDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var fromDate = new DateTime(patientOrderDate.Year, 1, 1, 0, 0, 0);
                    var toDate = new DateTime(patientOrderDate.Year, 1, 1, 0, 0, 0);
                    var lastOrderInYear = _patientOrderRepository.GetAll()
                        .Where(x => x.PatientOrderDate >= fromDate && x.PatientOrderDate < toDate)
                        .Max(x => x.SortOrder);
                        
                    var patientOrder = new PatientNumber();
                    patientOrder.Id = Guid.NewGuid();
                    patientOrder.PatientOrderDate = patientOrderDate;
                    patientOrder.SortOrder = lastOrderInYear + 1;
                    await _patientOrderRepository.InsertAsync(patientOrder);

                    unitOfWork.Complete();
                    result.Success(ObjectMapper.Map<PatientNumberDto>(patientOrder));
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
