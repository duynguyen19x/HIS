using HIS.ApplicationService.Business.MedicalRecords;
using HIS.ApplicationService.Business.Patients;
using HIS.ApplicationService.Business.Patients.Dto;
using HIS.ApplicationService.Business.Receptions.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities;
using HIS.EntityFrameworkCore.Entities.Business;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace HIS.ApplicationService.Business.Receptions
{
    public class ReceptionAppService : BaseAppService, IReceptionAppService
    {
        private readonly IRepository<Patient, Guid> _patientRepository;
        private readonly IRepository<PatientNumber, Guid> _patientOrderRepository;
        private readonly IRepository<MedicalRecord, Guid> _medicalRecordRepository;
        private readonly IRepository<Treatment, Guid> _treatmentRepository;
        private readonly IRepository<Reception, Guid> _receptionRepository;
        private readonly IRepository<Order, Guid> _orderRepository;
        private readonly IRepository<ServiceRequest, Guid> _serviceRequestRepository;
        private readonly IRepository<Invoice, Guid> _invoiceRepository;

        private readonly IPatientAppService _patientAppService;
        private readonly IMedicalRecordAppService _medicalRecordAppService;

        public ReceptionAppService(
            IRepository<Patient, Guid> patientRepository,
            IRepository<PatientNumber, Guid> patientOrderRepository,
            IRepository<MedicalRecord, Guid> medicalRecordRepository,
            IRepository<Treatment, Guid> treatmentRepository,
            IRepository<Reception, Guid> receptionRepository,
            IRepository<Order, Guid> orderRepository,
            IRepository<ServiceRequest, Guid> serviceRequestRepository,
            IRepository<Invoice, Guid> invoiceRepository,

            IPatientAppService patientAppService,
            IMedicalRecordAppService medicalRecordAppService
            ) 
        {
            _patientRepository = patientRepository;
            _patientOrderRepository = patientOrderRepository;
            _medicalRecordRepository = medicalRecordRepository;
            _treatmentRepository = treatmentRepository;
            _receptionRepository = receptionRepository;
            _orderRepository = orderRepository;
            _serviceRequestRepository = serviceRequestRepository;
            _invoiceRepository = invoiceRepository;

            _patientAppService = patientAppService;
            _medicalRecordAppService = medicalRecordAppService;
        }

        public async Task<ResultDto<ReceptionDto>> CreateOrEdit(ReceptionDto input)
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

        public async Task<ResultDto<ReceptionDto>> Create(ReceptionDto input)
        {
            var result = new ResultDto<ReceptionDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    if (Check.IsNullOrDefault(input.ReceptionDate))
                        input.ReceptionDate = DateTime.Now;

                    #region - bệnh án

                    var medicalRecordResult = await _medicalRecordAppService.CreateOrEdit(input.MedicalRecord);
                    if (!medicalRecordResult.IsSucceeded)
                    {
                        throw new Exception(medicalRecordResult.Message);
                    }

                    #endregion

                    #region - phiếu chỉ định

                    

                    #endregion

                    var reception = ObjectMapper.Map<Reception>(input);

                    await _receptionRepository.InsertAsync(reception);

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

        public async Task<ResultDto<ReceptionDto>> Update(ReceptionDto input)
        {
            var result = new ResultDto<ReceptionDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    #region - check



                    #endregion

                    #region - xử lý dữ liệu

                    var patient = ObjectMapper.Map<PatientDto>(input.MedicalRecord);
                    patient.Id = input.MedicalRecord.PatientId;

                    

                    #endregion

                    #region - lưu

                    var patientResult = await _patientAppService.CreateOrEdit(patient);
                    if (!patientResult.IsSucceeded)
                    {
                        throw new Exception(patientResult.Message);
                    }

                    var medicalRecordResult = await _medicalRecordAppService.CreateOrEdit(input.MedicalRecord);
                    if (!medicalRecordResult.IsSucceeded)
                    {
                        throw new Exception(medicalRecordResult.Message);
                    }

                    #endregion

                    #region - lưu log

                    #endregion

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

        public async Task<ResultDto<ReceptionDto>> Delete(Guid id)
        {
            var result = new ResultDto<ReceptionDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    // check
                    var reception = await _receptionRepository.FirstOrDefaultAsync(id);
                    if (reception == null)
                    {
                        throw new Exception("Dữ liệu tiếp đón không tồn tại!");
                    }    

                    var medicalRecord = await _medicalRecordRepository.FirstOrDefaultAsync(reception.MedicalRecordId) ?? new MedicalRecord();
                    if (medicalRecord.MedicalRecordStatusId == 0)
                    {
                        var invoices = await _invoiceRepository.GetAllListAsync(x => x.MedicalRecordId == medicalRecord.Id);
                        if (Check.Any(invoices))
                            throw new Exception("Bệnh nhân đã có hóa đơn!");
                    }
                    else
                    {
                        throw new Exception("Bệnh án đang được xử lý!");
                    }

                    //var treatments = await _treatmentRepository.GetAllListAsync(x => x.MedicalRecordId == medicalRecord.Id);
                    //var orders = await _orderRepository.GetAllListAsync(x=>x.MedicalRecordId == medicalRecord.Id);
                    //var serviceRequests = await _serviceRequestRepository.GetAllListAsync(x => x.MedicalRecordId == medicalRecord.Id);

                    var patient = await _patientRepository.FirstOrDefaultAsync(x => x.Id == medicalRecord.PatientId);
                    if (patient == null)
                    {
                        throw new Exception("Bệnh nhân không tồn tại!");
                    }

                    // handle
                    await _serviceRequestRepository.DeleteAsync(x => x.MedicalRecordId == medicalRecord.Id);
                    await _orderRepository.DeleteAsync(x => x.MedicalRecordId == medicalRecord.Id);
                    await _treatmentRepository.DeleteAsync(x => x.MedicalRecordId == medicalRecord.Id);
                    await _medicalRecordRepository.DeleteAsync(medicalRecord);
                    await _receptionRepository.DeleteAsync(reception);
                    // xóa số thứ tự (cấu hình)
                    if (true)
                    {
                        await _patientOrderRepository.DeleteAsync(x => x.Id == patient.PatientNumberId);
                    }    

                    // log
                    unitOfWork.Complete();
                    result.Success(new ReceptionDto()
                    {
                        Id = reception.Id
                    });
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async Task<PagedResultDto<ReceptionDto>> GetAll(GetAllReceptionInputDto input)
        {
            var result = new PagedResultDto<ReceptionDto>();

            var filter = _receptionRepository.GetAll()
                .WhereIf(input.MaxReceptionDateFilter != null, x => x.ReceptionDate <= input.MaxReceptionDateFilter)
                .WhereIf(input.MinReceptionDateFilter != null, x => x.ReceptionDate >= input.MinReceptionDateFilter)
                .WhereIf(input.BranchFilter != null, x => x.BranchId == input.BranchFilter)
                .WhereIf(input.DepartmentFilter != null, x => x.DepartmentId == input.DepartmentFilter)
                .WhereIf(input.RoomFilter != null, x => x.RoomId == input.RoomFilter)
                .WhereIf(input.GateFilter != null, x => x.Gate == input.GateFilter);

            if (Check.IsNullOrDefault(input.Sorting))
                input.Sorting = nameof(ReceptionDto.ReceptionDate);

            var paged = filter.ApplySortingAndPaging(input);


            result.TotalCount = await filter.CountAsync();
            result.Result = ObjectMapper.Map<IList<ReceptionDto>>(paged.ToList());
            result.IsSucceeded = true;

            return result;
        }

        public async Task<ResultDto<ReceptionDto>> Get(Guid id)
        {
            var result = new ResultDto<ReceptionDto>();
            var entity = await _receptionRepository.GetAsync(id);

            result.Result = ObjectMapper.Map<ReceptionDto>(entity);
            result.IsSucceeded = true;

            return result;
        }
    }
}
