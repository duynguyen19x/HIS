using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Dictionaries.PatientObjectTypes;
using HIS.Dtos.Dictionaries.ReceptionObjectTypes;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.ApplicationService.Dictionaries.ReceptionObjectTypes
{
    public class ReceptionObjectTypeAppService : BaseCrudAppService<ReceptionObjectTypeDto, int, GetAllReceptionObjectTypeInput>, IReceptionObjectTypeAppService
    {
        public ReceptionObjectTypeAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async override Task<ResultDto<ReceptionObjectTypeDto>> Create(ReceptionObjectTypeDto input)
        {
            var result = new ResultDto<ReceptionObjectTypeDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    input.Id = NewID();
                    var data = ObjectMapper.Map<ReceptionObjectType>(input);
                    data.CreatedDate = DateTime.Now;
                    data.CreatedBy = SessionExtensions.Login?.Id;
                    Context.ReceptionObjectTypes.Add(data);
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

        public async override Task<ResultDto<ReceptionObjectTypeDto>> Update(ReceptionObjectTypeDto input)
        {
            var result = new ResultDto<ReceptionObjectTypeDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var receptionObjectType = await Context.ReceptionObjectTypes.FindAsync(input.Id);
                    var data = ObjectMapper.Map<ReceptionObjectType>(input);
                    data.CreatedDate = receptionObjectType.CreatedDate;
                    data.CreatedBy = receptionObjectType.CreatedBy;
                    data.ModifiedDate = DateTime.Now;
                    data.ModifiedBy = SessionExtensions.Login?.Id;
                    Context.ReceptionObjectTypes.Update(data);
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

        public async override Task<ResultDto<ReceptionObjectTypeDto>> Delete(int id)
        {
            var result = new ResultDto<ReceptionObjectTypeDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var receptionObjectType = await Context.ReceptionObjectTypes.FindAsync(id);
                    Context.ReceptionObjectTypes.Remove(receptionObjectType);

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

        public async override Task<PagedResultDto<ReceptionObjectTypeDto>> GetAll(GetAllReceptionObjectTypeInput input)
        {
            var result = new PagedResultDto<ReceptionObjectTypeDto>();
            try
            {
                var filter = Context.ReceptionObjectTypes.AsQueryable()
                    .WhereIf(!string.IsNullOrEmpty(input.ReceptionObjectTypeCodeFilter), x => x.ReceptionObjectTypeCode == input.ReceptionObjectTypeCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.ReceptionObjectTypeNameFilter), x => x.ReceptionObjectTypeName == input.ReceptionObjectTypeNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.OrderBy(s => s.SortOrder).PageBy(input);

                result.TotalCount = await filter.CountAsync();
                result.Items = ObjectMapper.Map<IList<ReceptionObjectTypeDto>>(paged.ToList());
                result.IsSuccessed = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async override Task<ResultDto<ReceptionObjectTypeDto>> GetById(int id)
        {
            var result = new ResultDto<ReceptionObjectTypeDto>();
            try
            {
                var patientObjectType = await Context.ReceptionObjectTypes.FindAsync(id);
                result.Item = ObjectMapper.Map<ReceptionObjectTypeDto>(patientObjectType);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        private int NewID()
        {
            var data = Context.ReceptionObjectTypes.DefaultIfEmpty().Max(x => x.Id);
            return data + 1;
        }
    }
}
