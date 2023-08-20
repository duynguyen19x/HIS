using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;
using HIS.Core.Linq;
using HIS.Dtos.Business.Patient;
using HIS.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Business.Patient
{
    public class PatientAppService : BaseAppService, IPatientAppService
    {
        public PatientAppService(HISDbContext context, IMapper mapper)
            : base(context, mapper)
        {
        }

        public async Task<PagedResultDto<PatientDto>> GetAll(GetAllPatientInputDto input)
        {
            var result = new PagedResultDto<PatientDto>();
            try
            {
                var filter = Context.Patients.AsQueryable()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code.ToUpper() == input.CodeFilter.ToUpper())
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name.ToUpper() == input.NameFilter.ToUpper())
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                result.TotalCount = await filter.CountAsync();
                result.Items = (from p in filter
                                select new PatientDto()
                                {
                                    Id = p.Id,
                                    Code = p.Code,
                                    Name = p.Name,
                                    Description = p.Description,
                                    Inactive = p.Inactive
                                })
                                .PageBy(input)
                                .OrderBy(x => x.Code)
                                .ToList();
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return result;
        }

        public async Task<ResultDto<PatientDto>> GetById(Guid id)
        {
            var result = new ResultDto<PatientDto>();
            try
            {
                result.Item = Mapper.Map<PatientDto>(await Context.Patients.SingleOrDefaultAsync(p => p.Id == id));
            }
            catch (Exception ex)
            {
                result.IsSuccessed = false;
                result.Message = ex.Message;
            }

            return result;
        }

        public async Task<ResultDto<PatientDto>> CreateOrEdit(PatientDto input)
        {
            if (input.Id == null)
                return await Create(input);
            else
                return await Update(input);
        }

        public async Task<ResultDto<PatientDto>> Create(PatientDto input)
        {
            var result = new ResultDto<PatientDto>();
            await Context.TransactionAsync(async () =>
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    if (string.IsNullOrEmpty(input.Code))
                        input.Code = "BN" + DateTime.Now.Year + (Context.Patients.Count() + 1).ToString().PadLeft(5, '0');

                    // map
                    var patient = Mapper.Map<EntityFrameworkCore.Entities.Business.Patient>(input);
                    patient.CreatedDate = DateTime.Now;
                    patient.CreatedBy = Guid.NewGuid(); // giả lập tài khoản create

                    Context.Add(patient);
                    await Context.SaveChangesAsync();

                    result.Item = input;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            });

            return result;
        }

        public async Task<ResultDto<PatientDto>> Update(PatientDto input)
        {
            var result = new ResultDto<PatientDto>();
            using (var transaction = Context.BeginTransaction())
            {
                try
                {
                    // kiểm tra dữ liệu tại đây

                    // mã bệnh nhân
                    if (string.IsNullOrEmpty(input.Code))
                        input.Code = "BN" + DateTime.Now.Year + Context.Patients.Count().ToString().PadLeft(5, '0');

                    // map
                    var patient = Mapper.Map<EntityFrameworkCore.Entities.Business.Patient>(input);
                    patient.ModifiedDate = DateTime.Now;
                    patient.ModifiedBy = Guid.NewGuid(); // giả lập tài khoản update

                    Context.Update(patient);
                    await Context.SaveChangesAsync();
                    result.Item = input;

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return await Task.FromResult(result);
        }

        public async Task<ResultDto<PatientDto>> Delete(Guid id)
        {
            var result = new ResultDto<PatientDto>();
            using (var transaction = Context.BeginTransaction())
            {
                try
                {
                    var patient = Context.Patients.SingleOrDefault(x => x.Id == id);
                    if (patient != null)
                    {
                        Context.Remove(patient);
                        await Context.SaveChangesAsync();

                        transaction.Commit();
                    }
                }
                catch (Exception ex)
                {
                    result.IsSuccessed = false;
                    result.Message = ex.Message;
                }
                finally
                {
                    transaction.Dispose();
                }
            }
            return result;
        }
    }
}
