using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Dictionaries.ReceptionTypes;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Dictionaries.ReceptionTypes
{
    public class ReceptionTypeAppService : BaseCrudAppService<ReceptionTypeDto, int, GetAllReceptionTypeInput>, IReceptionTypeAppService
    {
        public ReceptionTypeAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async override Task<ResultDto<ReceptionTypeDto>> Create(ReceptionTypeDto input)
        {
            var result = new ResultDto<ReceptionTypeDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    input.Id = NewID();
                    var data = ObjectMapper.Map<ReceptionType>(input);
                    data.CreatedDate = DateTime.Now;
                    data.CreatedBy = SessionExtensions.Login?.Id;
                    Context.ReceptionTypes.Add(data);
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

        public async override Task<ResultDto<ReceptionTypeDto>> Update(ReceptionTypeDto input)
        {
            var result = new ResultDto<ReceptionTypeDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var receptionType = await Context.ReceptionTypes.FindAsync(input.Id);
                    var data = ObjectMapper.Map<ReceptionType>(input);
                    data.CreatedDate = receptionType.CreatedDate;
                    data.CreatedBy = receptionType.CreatedBy;
                    data.ModifiedDate = DateTime.Now;
                    data.ModifiedBy = SessionExtensions.Login?.Id;
                    Context.ReceptionTypes.Update(data);
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

        public async override Task<ResultDto<ReceptionTypeDto>> Delete(int id)
        {
            var result = new ResultDto<ReceptionTypeDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var receptionType = await Context.ReceptionTypes.FindAsync(id);
                    Context.ReceptionTypes.Remove(receptionType);

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

        public async override Task<PagedResultDto<ReceptionTypeDto>> GetAll(GetAllReceptionTypeInput input)
        {
            var result = new PagedResultDto<ReceptionTypeDto>();
            try
            {
                var filter = Context.ReceptionTypes.AsQueryable()
                    .WhereIf(!string.IsNullOrEmpty(input.ReceptionTypeCodeFilter), x => x.ReceptionTypeCode == input.ReceptionTypeCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.ReceptionTypeNameFilter), x => x.ReceptionTypeName == input.ReceptionTypeNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.OrderBy(s => s.SortOrder).PageBy(input);

                result.TotalCount = await filter.CountAsync();
                result.Items = ObjectMapper.Map<IList<ReceptionTypeDto>>(paged.ToList());
                result.IsSuccessed = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async override Task<ResultDto<ReceptionTypeDto>> GetById(int id)
        {
            var result = new ResultDto<ReceptionTypeDto>();
            try
            {
                var patientType = await Context.ReceptionTypes.FindAsync(id);
                result.Item = ObjectMapper.Map<ReceptionTypeDto>(patientType);
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
            var data = Context.ReceptionTypes.DefaultIfEmpty().Max(x => x.Id);
            return data + 1;
        }
    }
}
