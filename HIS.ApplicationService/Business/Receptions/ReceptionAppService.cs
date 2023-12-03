using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Business.MedicalRecords;
using HIS.Dtos.Business.Receptions;
using HIS.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Business.Receptions
{
    /// <summary>
    /// Đăng ký khám.
    /// </summary>
    public class ReceptionAppService : BaseCrudAppService<ReceptionDto, Guid, GetAllReceptionInputDto>, IReceptionAppService
    {
        public ReceptionAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async override Task<ResultDto<ReceptionDto>> Create(ReceptionDto input)
        {
            var result = new ResultDto<ReceptionDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {

                    await SaveChangesAsync();
                    await transaction.CommitAsync();

                    result.IsSucceeded = true;
                    result.Item = input;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public override Task<ResultDto<ReceptionDto>> Update(ReceptionDto input)
        {
            throw new NotImplementedException();
        }

        public override Task<ResultDto<ReceptionDto>> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public override async Task<PagedResultDto<ReceptionDto>> GetAll(GetAllReceptionInputDto input)
        {
            var result = new PagedResultDto<ReceptionDto>();
            try
            {
                //var receptionFilter = Context.Receptions.AsNoTracking()
                //    .WhereIf(input.MaxReceptionDateFilter != null, x => x.ReceptionDate <= input.MaxReceptionDateFilter)
                //    .WhereIf(input.MinReceptionDateFilter != null, x => x.ReceptionDate >= input.MinReceptionDateFilter)
                //    .WhereIf(input.PatientTypeFilter != null, x => x.PatientTypeID == input.PatientTypeFilter)
                //    .WhereIf(input.ReceptionTypeFilter != null, x => x.ReceptionTypeID == input.ReceptionTypeFilter)
                //    .WhereIf(input.DepartmentFilter != null, x => x.DepartmentID == input.DepartmentFilter)
                //    .WhereIf(input.RoomFilter != null, x => x.RoomID == input.RoomFilter)
                //    .WhereIf(input.UserFilter != null, x => x.UserID == input.UserFilter)
                //    .WhereIf(input.ExecuteDepartmentFilter != null, x => x.ExecuteDepartmentID == input.ExecuteDepartmentFilter)
                //    .WhereIf(input.ExecuteRoomFilter != null, x => x.ExecuteRoomID == input.ExecuteRoomFilter)
                //    .WhereIf(input.UserFilter != null, x => x.UserID == input.UserFilter);

                //var medicalRecordFilter = Context.MedicalRecords.AsNoTracking()
                //    .WhereIf(input.GenderFilter != null, x => x.GenderID == input.GenderFilter);

                //var patientFilter = Context.Patients.AsNoTracking();

                //var filter = from o in receptionFilter
                //             join m in medicalRecordFilter on o.MedicalRecordID equals m.Id
                //             join p in patientFilter on m.PatientID equals p.Id

                //             join o1 in Context.Departments.AsNoTracking() on o.DepartmentID equals o1.Id into s1 from d1 in s1.DefaultIfEmpty()

                //             join o2 in Context.Departments.AsNoTracking() on o.ExecuteDepartmentID equals o2.Id into s2 from d2 in s2.DefaultIfEmpty()

                //             join o3 in Context.Rooms.AsNoTracking() on o.RoomID equals o3.Id into s3 from r1 in s3.DefaultIfEmpty()

                //             join o4 in Context.Rooms.AsNoTracking() on o.ExecuteRoomID equals o4.Id into s4 from r2 in s4.DefaultIfEmpty()

                //             join o5 in Context.Users.AsNoTracking() on o.UserID equals o5.Id into s5 from u1 in s5.DefaultIfEmpty()

                //             join o6 in Context.Users.AsNoTracking() on o.ExecuteUserID equals o6.Id into s6 from u2 in s6.DefaultIfEmpty()

                //             join g in Context.Genders.AsNoTracking() on m.GenderID equals g.Id

                //             join s in Context.Services.AsNoTracking() on o.ServiceID equals s.Id

                //             select new ReceptionDto()
                //             {
                //                 Id = o.Id,
                //                 ReceptionDate = o.ReceptionDate,
                //                 ReceptionTypeID = o.ReceptionTypeID,
                //                 PatientTypeID = o.PatientTypeID,
                //                 PatientID = m.PatientID,
                //                 MedicalRecordID = o.MedicalRecordID,
                //                 TreatmentID = o.TreatmentID,
                //                 BranchID = o.BranchID,
                //                 DepartmentID = o.DepartmentID,
                //                 RoomID = o.RoomID,
                //                 UserID = o.UserID,
                //                 BirthDate = m.BirthDate,
                //                 BirthYear = m.BirthYear,
                //                 Address = m.Address,
                //                 IsPriority = o.IsPriority,
                //                 HospitalizationReason = o.HospitalizationReason,
                //                 Description = o.Description,

                //                 PatientCode = p.PatientCode,
                //                 PatientName = m.PatientName,
                //                 DepartmentName = d1.DepartmentName,
                //                 RoomName = r1.RoomName,
                //                 UserName = u1.UserName,
                //                 ExecuteDepartmentName = d2.DepartmentName,
                //                 ExecuteRoomName = r2.RoomName,
                //                 ExecuteUserName = u2.UserName,
                //                 GenderName = g.GenderName,
                //                 ServiceName = s.Name
                //             };

                var paged = filter.OrderBy(o => o.ReceptionDate).PageBy(input);

                result.TotalCount = await filter.CountAsync();
                result.Items = filter.ToList();
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public override async Task<ResultDto<ReceptionDto>> GetById(Guid id)
        {
            var result = new ResultDto<ReceptionDto>();
            try
            {
                var reception = await Context.Receptions.FindAsync(id);
                if (reception != null)
                {
                    var medicalRecord = await Context.MedicalRecords.FindAsync(reception.MedicalRecordID);
                    var treatment = await Context.Treatments.FindAsync(reception.TreatmentID);

                    var dto = ObjectMapper.Map<ReceptionDto>(reception);
                    dto.MedicalRecord = ObjectMapper.Map<MedicalRecordDto>(medicalRecord);
                    dto.Treatment = ObjectMapper.Map<TreatmentDto>(treatment);

                    result.Item = dto;
                    result.IsSucceeded = true;
                }
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        
    }
}
