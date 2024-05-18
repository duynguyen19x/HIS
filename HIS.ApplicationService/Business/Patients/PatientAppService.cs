using HIS.ApplicationService.Business.Patients.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace HIS.ApplicationService.Business.Patients
{
    public class PatientAppService : BaseAppService, IPatientAppService
    {
        private readonly IRepository<Patient, Guid> _patientRepository;
        private readonly IRepository<PatientOrder, Guid> _patientOrderRepository;

        private readonly IPatientOrderAppService _patientOrderAppService;

        public PatientAppService(
            IRepository<Patient, Guid> patientRepository,
            IRepository<PatientOrder, Guid> patientOrderRepository,
            PatientOrderAppService patientOrderAppService) 
        {
            _patientRepository = patientRepository;
            _patientOrderRepository = patientOrderRepository;

            _patientOrderAppService = patientOrderAppService;
        }

        public virtual async Task<PagedResultDto<PatientDto>> GetAll(GetAllPatientInputDto input)
        {
            var result = new PagedResultDto<PatientDto>();
            try
            {
                var filter = _patientRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.PatientCodeFilter), x => x.PatientCode.Contains(input.PatientCodeFilter))
                    .WhereIf(!string.IsNullOrEmpty(input.PatientNameFilter), x => x.PatientName.Contains(input.PatientNameFilter))
                    .WhereIf(input.MaxBirthDate != null, x => x.BirthDate <= input.MaxBirthDate)
                    .WhereIf(input.MinBirthDate != null, x => x.BirthDate >= input.MinBirthDate)
                    ;

                if (Check.IsNullOrDefault(input.Sorting))
                    input.Sorting = "Code";

                var paged = filter.ApplySortingAndPaging(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<PatientDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<PatientDto>> Get(Guid id)
        {
            var result = new ResultDto<PatientDto>();
            try
            {
                var data = await _patientRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<PatientDto>(data);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<PatientDto>> CreateOrEdit(PatientDto input)
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

        public virtual async Task<ResultDto<PatientDto>> Create(PatientDto input)
        {
            var result = new ResultDto<PatientDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var createdDate = DateTime.Now;

                    input.Id = Guid.NewGuid();

                    // chi nhánh
                    if (Check.IsNullOrDefault(input.BranchID))
                    {
                        //input.BranchID = SessionExtensions.Login.Te
                    }

                    // số thứ tự bệnh nhân
                    if (Check.IsNullOrDefault(input.PatientOrderID))
                    {
                        var patientOrderResult = await _patientOrderAppService.CreateLastOrder(createdDate);
                        if (patientOrderResult.IsSucceeded)
                        {
                            input.PatientOrderID = patientOrderResult.Result.Id;
                            input.PatientOrderDate = patientOrderResult.Result.PatientOrderDate;
                            input.PatientOrderValue = patientOrderResult.Result.SortOrder;
                        }    
                    }

                    // mã bệnh nhân
                    if (Check.IsNullOrDefault(input.PatientCode))
                    {
                        // input.PatientCode = GetPatientCode();
                    }    

                    var patient = ObjectMapper.Map<Patient>(input);

                    await _patientRepository.InsertAsync(patient);
                    unitOfWork.Complete();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<PatientDto>> Update(PatientDto input)
        {
            var result = new ResultDto<PatientDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _patientRepository.GetAsync(input.Id.GetValueOrDefault());

                    ObjectMapper.Map(input, entity);
                    unitOfWork.Complete();

                    result.Result = ObjectMapper.Map<PatientDto>(entity);
                    result.IsSucceeded = true;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<PatientDto>> Delete(Guid id)
        {
            var result = new ResultDto<PatientDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin())
            {
                try
                {
                    var entity = _patientRepository.Get(id);
                    await _patientRepository.DeleteAsync(entity);

                    result.Result = ObjectMapper.Map<PatientDto>(entity);
                    result.IsSucceeded = true;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }



        private string GetPatientCode(PatientOrder patientOrder)
        {
            var year = patientOrder.PatientOrderDate.Year % 1000;
            if (year > 100)
                year = year % 100;
            return year.ToString().PadLeft(2, '0') + patientOrder.SortOrder.ToString().PadLeft(8, '0');
        }
    }
}
