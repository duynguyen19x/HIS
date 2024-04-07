using HIS.ApplicationService.Business.Receptions.Dto;
using HIS.Core.Application.Services;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Extensions;
using HIS.EntityFrameworkCore.Entities.Business;
using HIS.EntityFrameworkCore.Entities.Categories;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.EntityFrameworkCore.Entities.Dictionary;
using HIS.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Transactions;

namespace HIS.ApplicationService.Business.Receptions
{
    /// <summary>
    /// Phòng tiếp đón.
    /// </summary>
    public class ReceptionAppService : BaseAppService, IReceptionAppService
    {
        private readonly IRepository<Reception, Guid> _receptionRepository;
        private readonly IRepository<Patient, Guid> _patientRepository;
        private readonly IRepository<PatientRecord, Guid> _patientRecordRepository;
        private readonly IRepository<ReceptionObjectType, int> _receptionObjectTypeRepository;
        private readonly IRepository<PatientObjectType, int> _patientObjectTypeRepository;
        private readonly IRepository<Service, Guid> _serviceRepository;

        public ReceptionAppService(
            IRepository<Reception, Guid> receptionRepository, 
            IRepository<Patient, Guid> patientRepository,
            IRepository<PatientRecord, Guid> patientRecordRepository,
            IRepository<ReceptionObjectType, int> receptionObjectTypeRepository,
            IRepository<PatientObjectType, int> patientObjectTypeRepository) 
        {
            _receptionRepository = receptionRepository;
            _patientRepository = patientRepository;
            _patientRecordRepository = patientRecordRepository;
            _receptionObjectTypeRepository = receptionObjectTypeRepository;
            _patientObjectTypeRepository = patientObjectTypeRepository;
        }

        public virtual async Task<PagedResultDto<ReceptionDto>> GetAll(GetAllReceptionInputDto input)
        {
            var result = new PagedResultDto<ReceptionDto>();
            try
            {
                var filter = _receptionRepository.GetAll()
                    .WhereIf(input.ReceptionFromDateFilter != null, x => x.ReceptionDate >= input.ReceptionFromDateFilter)
                    .WhereIf(input.ReceptionToDateFilter != null, x => x.ReceptionDate <= input.ReceptionToDateFilter)
                    .WhereIf(input.ReceptionObjectTypeFilter != null, x => x.ReceptionObjectTypeId == input.ReceptionObjectTypeFilter)
                    .WhereIf(input.PatientObjectTypeFilter != null, x => x.PatientObjectTypeId == input.PatientObjectTypeFilter)
                    .WhereIf(input.BranchFilter != null, x => x.BranchId == input.BranchFilter)
                    .WhereIf(input.DepartmentFilter != null, x => x.DepartmentId == input.DepartmentFilter)
                    .WhereIf(input.RoomFilter != null, x => x.RoomId == input.RoomFilter)
                    .WhereIf(input.UserFilter != null, x => x.UserId == input.UserFilter)
                    .WhereIf(input.ExecuteDepartmentFilter != null, x => x.ExecuteDepartmentId == input.ExecuteDepartmentFilter)
                    .WhereIf(input.ExecuteRoomFilter != null, x => x.ExecuteRoomId == input.ExecuteRoomFilter)
                    .WhereIf(input.ExecuteUserFilter != null, x => x.ExecuteUserId == input.ExecuteUserFilter);

                filter = filter.ApplySortingAndPaging(input);

                var paged = from o in filter

                            join o1 in _patientRepository.GetAll() on o.PatientId equals o1.Id

                            join o2 in _patientRecordRepository.GetAll() on o.PatientRecordId equals o2.Id

                            join s1 in _receptionObjectTypeRepository.GetAll() on o.ReceptionObjectTypeId equals s1.Id

                            join s2 in _patientObjectTypeRepository.GetAll() on o.PatientObjectTypeId equals s2.Id

                            select new ReceptionDto()
                            {
                                Id = o.Id,
                                PatientId = o.PatientId,
                                PatientRecordId = o.PatientRecordId,
                                MedicalRecordId = o.MedicalRecordId,
                                PatientCode = o1.Code,
                                PatientRecordCode = o2.Code,
                                PatientName = o2.Name,
                                ReceptionDate = o.ReceptionDate,
                                ReceptionObjectTypeId = o.ReceptionObjectTypeId,
                                ReceptionObjectTypeName = s1.Name,
                                PatientObjectTypeId = o.PatientObjectTypeId,
                                PatientObjectTypeName = s2.Name,
                                HospitalizationReason = o.HospitalizationReason,
                                Description = o.Description,
                                BranchId = o.BranchId,
                                DepartmentId = o.DepartmentId,
                                RoomId = o.RoomId,
                                Gate = o.Gate,
                                UserId = o.UserId,
                                ServiceId = o.ServiceId,
                                ExecuteDepartmentId = o.ExecuteDepartmentId,
                                ExecuteRoomId = o.ExecuteRoomId,
                                ExecuteUserId = o.ExecuteUserId,
                            };

                result.TotalCount = await filter.CountAsync();
                result.Result = paged.ToList();
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public Task<ResultDto<ReceptionDto>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<ResultDto<ReceptionDto>> CreateOrEdit(ReceptionDto input)
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

        public virtual async Task<ResultDto<ReceptionDto>> Create(ReceptionDto input)
        {
            var result = new ResultDto<ReceptionDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();

                    if (Check.IsNullOrDefault(input.PatientId))
                    {
                        input.PatientId = Guid.NewGuid();
                        var patient = ObjectMapper.Map<Patient>(input.PatientRecord);
                        patient.Code = "BN";
                    }   
                    
                    if (Check.IsNullOrDefault(input.PatientRecord.Id))
                    {
                        input.PatientRecordId = Guid.NewGuid();
                        var patientRecord = ObjectMapper.Map<PatientRecord>(input.PatientRecord);
                        patientRecord.Code = "BA";
                    }

                    var reception = ObjectMapper.Map<Reception>(input);
                    await _receptionRepository.InsertAsync(reception);

                    await unitOfWork.CompleteAsync();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<ReceptionDto>> Update(ReceptionDto input)
        {
            var result = new ResultDto<ReceptionDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {

                    await unitOfWork.CompleteAsync();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<ReceptionDto>> Delete(Guid id)
        {
            var result = new ResultDto<ReceptionDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var reception = _receptionRepository.Get(id);
                    var patientRecord = _patientRecordRepository.Get(reception.PatientRecordId);
                    if (patientRecord.PatientRecordStatusId > 0)
                    {
                        throw new Exception("Bệnh nhân đang điều trị!");
                    }

                    await _receptionRepository.DeleteAsync(reception);
                    await _patientRecordRepository.DeleteAsync(patientRecord);


                    await unitOfWork.CompleteAsync();
                    result.Success(null);
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
