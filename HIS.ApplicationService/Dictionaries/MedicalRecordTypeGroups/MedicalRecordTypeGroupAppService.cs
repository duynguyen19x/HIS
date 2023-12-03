using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Dictionaries.Ethnicities;
using HIS.Dtos.Dictionaries.MedicalRecordTypeGroups;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.MedicalRecordTypeGroups
{
    public class MedicalRecordTypeGroupAppService : BaseCrudAppService<MedicalRecordTypeGroupDto, int, GetAllMedicalRecordTypeGroupInput>, IMedicalRecordTypeGroupAppService
    {
        public MedicalRecordTypeGroupAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async override Task<ResultDto<MedicalRecordTypeGroupDto>> Create(MedicalRecordTypeGroupDto input)
        {
            var result = new ResultDto<MedicalRecordTypeGroupDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    input.Id = Context.NewID<MedicalRecordTypeCategory>();
                    var data = ObjectMapper.Map<MedicalRecordTypeCategory>(input);
                    data.CreatedDate = DateTime.Now;
                    data.CreatedBy = SessionExtensions.Login?.Id;
                    Context.MedicalRecordTypeGroups.Add(data);
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

        public async override Task<ResultDto<MedicalRecordTypeGroupDto>> Update(MedicalRecordTypeGroupDto input)
        {
            var result = new ResultDto<MedicalRecordTypeGroupDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var ethnicity = await Context.MedicalRecordTypeGroups.FindAsync(input.Id);
                    var data = ObjectMapper.Map<MedicalRecordTypeCategory>(input);
                    data.CreatedDate = ethnicity.CreatedDate;
                    data.CreatedBy = ethnicity.CreatedBy;
                    data.ModifiedDate = DateTime.Now;
                    data.ModifiedBy = SessionExtensions.Login?.Id;
                    Context.MedicalRecordTypeGroups.Update(data);
                    await SaveChangesAsync();
                    transaction.Commit();

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

        public async override Task<ResultDto<MedicalRecordTypeGroupDto>> Delete(int id)
        {
            var result = new ResultDto<MedicalRecordTypeGroupDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var medicalRecordTypeGroup = await Context.MedicalRecordTypeGroups.FindAsync(id);
                    Context.MedicalRecordTypeGroups.Remove(medicalRecordTypeGroup);

                    await SaveChangesAsync();
                    transaction.Commit();

                    result.IsSucceeded = true;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async override Task<PagedResultDto<MedicalRecordTypeGroupDto>> GetAll(GetAllMedicalRecordTypeGroupInput input)
        {
            var result = new PagedResultDto<MedicalRecordTypeGroupDto>();
            try
            {
                var filter = Context.MedicalRecordTypeGroups.AsQueryable()
                    .WhereIf(!string.IsNullOrEmpty(input.MedicalRecordTypeGroupCodeFilter), x => x.MedicalRecordTypeGroupCode == input.MedicalRecordTypeGroupCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.MedicalRecordTypeGroupNameFilter), x => x.MedicalRecordTypeGroupName == input.MedicalRecordTypeGroupNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.OrderBy(s => s.SortOrder).PageBy(input);

                result.TotalCount = await filter.CountAsync();
                result.Items = ObjectMapper.Map<IList<MedicalRecordTypeGroupDto>>(paged.ToList());
                result.IsSuccessed = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async override Task<ResultDto<MedicalRecordTypeGroupDto>> GetById(int id)
        {
            var result = new ResultDto<MedicalRecordTypeGroupDto>();
            try
            {
                var medicalRecordTypeGroup = await Context.MedicalRecordTypeGroups.FindAsync(id);
                result.Item = ObjectMapper.Map<MedicalRecordTypeGroupDto>(medicalRecordTypeGroup);
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
