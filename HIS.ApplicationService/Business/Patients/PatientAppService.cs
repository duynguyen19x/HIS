using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Application.Core.Utils;
using HIS.Core.Extensions;
using HIS.Core.Linq;
using HIS.Dtos.Business.Patients;
using HIS.EntityFrameworkCore.Entities.Business;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (DataHelper.IsNullOrDefault(input.PatientId))
                return await Create(input);
            else
                return await Update(input);
        }

        public virtual async Task<ResultDto<PatientDto>> Create(PatientDto input)
        {
            return await BeginTransactionAsync<ResultDto<PatientDto>>(async result =>
            {
                try
                {
                    input.PatientId = Guid.NewGuid();
                    if (DataHelper.IsNullOrDefault(input.PatientCode))
                        input.PatientCode = "BN" + String.Format("{0:00000}", Context.Patients.Count() + 1);

                    var patient = ObjectMapper.Map<Patient>(input);
                    patient.CreatedDate = DateTime.Now;
                    patient.CreatedBy = SessionExtensions.Login.Id;

                    Context.Patients.Add(patient);

                    result.Item = input;
                    await SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            });
        }

        public virtual async Task<ResultDto<PatientDto>> Update(PatientDto input)
        {
            return await BeginTransactionAsync<ResultDto<PatientDto>>(async result =>
            {
                try
                {
                    var patient = ObjectMapper.Map<Patient>(input);
                    patient.ModifiedDate = DateTime.Now;
                    patient.ModifiedBy = SessionExtensions.Login.Id;

                    Context.Patients.Update(patient);

                    result.Item = input;
                    await SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            });
        }

        public virtual async Task<ResultDto<PatientDto>> Delete(Guid id)
        {
            return await BeginTransactionAsync<ResultDto<PatientDto>>(async result =>
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
        }

        public virtual async Task<PagedResultDto<PatientDto>> GetAll(PatientRequestDto input)
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
