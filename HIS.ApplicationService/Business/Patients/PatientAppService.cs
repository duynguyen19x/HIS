using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Application.Core.Utils;
using HIS.Core.Linq;
using HIS.Dtos.Business.Patients;
using HIS.EntityFrameworkCore.Entities.Business;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Business.Patients
{
    public class PatientAppService : BaseAppService, IPatientAppService
    {
        public PatientAppService(HISDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public virtual async Task<ResultDto<PatientDto>> CreateOrEdit(PatientDto input)
        {
            if (DataHelper.IsNullOrDefault(input.Id))
                return await Create(input);
            else
                return await Update(input);
        }

        public virtual async Task<ResultDto<PatientDto>> Create(PatientDto input) => await BeginTransactionAsync<ResultDto<PatientDto>>(async result =>
        {
            try
            {
                // kiểm tra dữ liệu
                if (DataHelper.IsNullOrDefault(input.Name))
                    result.Error(nameof(PatientDto.Name), "Tên bệnh nhân không được bỏ trống!");

                if (!result.HasErrors)
                {
                    input.Id = Guid.NewGuid();
                    if (DataHelper.IsNullOrDefault(input.Code))
                        input.Code = "BN" + String.Format("{0:00000}", Context.Patients.Count() + 1);

                    var patient = ObjectMapper.Map<Patient>(input);
                    patient.CreatedDate = DateTime.Now;
                    patient.CreatedBy = SessionExtensions.Login?.Id;

                    Context.Patients.Add(patient);
                    await SaveChangesAsync();

                    result.Item = input;
                }
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
        });

        public virtual async Task<ResultDto<PatientDto>> Update(PatientDto input) => await BeginTransactionAsync<ResultDto<PatientDto>>(async result =>
        {
            try
            {
                // kiểm tra dữ liệu
                if (DataHelper.IsNullOrDefault(input.Code))
                    result.Error(nameof(PatientDto.Code), "Mã bệnh nhân không được bỏ trống!");
                if (DataHelper.IsNullOrDefault(input.Name))
                    result.Error(nameof(PatientDto.Name), "Tên bệnh nhân không được bỏ trống!");
                input.BloodTypeId = 0;
                input.BloodRhTypeId = 0;

                if (!result.HasErrors)
                {
                    var patient = ObjectMapper.Map<Patient>(input);
                    patient.ModifiedDate = DateTime.Now;
                    patient.ModifiedBy = SessionExtensions.Login?.Id;

                    Context.Patients.Update(patient);

                    result.Item = input;
                    await SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
        });

        public virtual async Task<ResultDto<PatientDto>> Delete(Guid id) => await BeginTransactionAsync<ResultDto<PatientDto>>(async result =>
        {
            try
            {
                var patient = Context.Patients.SingleOrDefault(x => x.Id == id);
                if (patient != null)
                {
                    Context.Patients.Remove(patient);
                    await SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
        });

        public virtual async Task<PagedResultDto<PatientDto>> GetAll(PagedPatientInputDto input)
        {
            var result = new PagedResultDto<PatientDto>();
            try
            {
                var filter = Context.Patients.AsQueryable()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code.ToLower() == input.CodeFilter.ToLower());
                var paged = await filter.PageBy(input).ToListAsync();
                var totalCount = await filter.CountAsync();

                result.Items = ObjectMapper.Map<IList<PatientDto>>(paged);
                result.TotalCount = totalCount;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return result;
        }

        public virtual async Task<ResultDto<PatientDto>> GetById(Guid id)
        {
            var result = new ResultDto<PatientDto>();
            try
            {
                result.Item = ObjectMapper.Map<PatientDto>(await Context.Patients.FindAsync(id));
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }
    }
}
