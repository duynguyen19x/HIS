using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Dictionaries.Ethnicities;
using HIS.Dtos.Dictionaries.MedicalRecordTypes;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.MedicalRecordTypes
{
    public class MedicalRecordTypeAppService : BaseCrudAppService<MedicalRecordTypeDto, int, GetAllMedicalRecordTypeInput>, IMedicalRecordTypeAppService
    {
        public MedicalRecordTypeAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async override Task<ResultDto<MedicalRecordTypeDto>> Create(MedicalRecordTypeDto input)
        {
            var result = new ResultDto<MedicalRecordTypeDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    input.Id = Context.NewID<MedicalRecordType>();
                    var data = ObjectMapper.Map<MedicalRecordType>(input);
                    data.CreatedDate = DateTime.Now;
                    data.CreatedBy = SessionExtensions.Login?.Id;
                    Context.MedicalRecordTypes.Add(data);
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

        public async override Task<ResultDto<MedicalRecordTypeDto>> Update(MedicalRecordTypeDto input)
        {
            var result = new ResultDto<MedicalRecordTypeDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var medicalRecordType = await Context.MedicalRecordTypes.FindAsync(input.Id);
                    var data = ObjectMapper.Map<MedicalRecordType>(input);
                    data.CreatedDate = medicalRecordType.CreatedDate;
                    data.CreatedBy = medicalRecordType.CreatedBy;
                    data.ModifiedDate = DateTime.Now;
                    data.ModifiedBy = SessionExtensions.Login?.Id;
                    Context.MedicalRecordTypes.Update(data);
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

        public async override Task<ResultDto<MedicalRecordTypeDto>> Delete(int id)
        {
            var result = new ResultDto<MedicalRecordTypeDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var medicalRecordType = await Context.MedicalRecordTypes.FindAsync(id);
                    Context.MedicalRecordTypes.Remove(medicalRecordType);

                    await SaveChangesAsync();
                    await transaction.CommitAsync();

                    result.IsSucceeded = true;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async override Task<PagedResultDto<MedicalRecordTypeDto>> GetAll(GetAllMedicalRecordTypeInput input)
        {
            var result = new PagedResultDto<MedicalRecordTypeDto>();
            try
            {
                var filter = Context.MedicalRecordTypes.AsQueryable()
                    .WhereIf(!string.IsNullOrEmpty(input.MedicalRecordTypeCodeFilter), x => x.MedicalRecordTypeCode == input.MedicalRecordTypeCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.MedicalRecordTypeNameFilter), x => x.MedicalRecordTypeName == input.MedicalRecordTypeCodeFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter)
                    .WhereIf(input.MedicalRecordTypeGroupFilter != null, x => x.MedicalRecordTypeGroupID == input.MedicalRecordTypeGroupFilter);

                var paged = filter.OrderBy(s => s.SortOrder).PageBy(input);

                result.TotalCount = await filter.CountAsync();
                result.Items = ObjectMapper.Map<IList<MedicalRecordTypeDto>>(paged.ToList());
                result.IsSuccessed = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async override Task<ResultDto<MedicalRecordTypeDto>> GetById(int id)
        {
            var result = new ResultDto<MedicalRecordTypeDto>();
            try
            {
                var medicalRecordType = await Context.MedicalRecordTypes.FindAsync(id);
                result.Item = ObjectMapper.Map<MedicalRecordTypeDto>(medicalRecordType);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }
    }
}
