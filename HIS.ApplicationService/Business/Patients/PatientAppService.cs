using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Extensions;
using HIS.Core.Linq;
using HIS.Dtos.Business.Patients;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Business.Patients
{
    public class PatientAppService : BaseCrudAppService<PatientDto, PatientRequestDto>, IPatientAppService
    {
        public PatientAppService(HISDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public override async Task<ResultDto<PatientDto>> Create(PatientDto input)
        {
            return await BeginTransactionAsync<ResultDto<PatientDto>>(async result =>
            {
                try
                {



                    await SaveChangesAsync();
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            });
        }

        public override Task<ResultDto<PatientDto>> Update(PatientDto input)
        {
            throw new NotImplementedException();
        }

        public override async Task<ResultDto<PatientDto>> Delete(Guid id)
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

        public override async Task<PagedResultDto<PatientDto>> GetAll(PatientRequestDto input)
        {
            var result = new PagedResultDto<PatientDto>();
            try
            {
                var filter = Context.Patients.AsQueryable()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code.ToLower() == input.CodeFilter.ToLower());
                var paged = await filter.PageBy(input).ToListAsync();
                var totalCount = await filter.CountAsync();

                result.Items = Mapper.Map<IList<PatientDto>>(paged);
                result.TotalCount = totalCount;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return result;
        }

        public override async Task<ResultDto<PatientDto>> GetById(Guid id)
        {
            var result = new ResultDto<PatientDto>();
            try
            {
                result.Item = Mapper.Map<PatientDto>(await Context.Patients.FindAsync(id));
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }
    }
}
