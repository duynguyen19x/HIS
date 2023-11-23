using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Dictionaries.Ethnicities;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Dictionaries.Ethnicities
{
    public class EthnicityAppService : BaseCrudAppService<EthnicityDto, Guid, GetAllEthnicityInput>, IEthnicityAppService
    {
        public EthnicityAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async override Task<ResultDto<EthnicityDto>> Create(EthnicityDto input)
        {
            var result = new ResultDto<EthnicityDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = ObjectMapper.Map<Ethnicity>(input);
                    data.CreatedDate = DateTime.Now;
                    data.CreatedBy = SessionExtensions.Login?.Id;
                    Context.Ethnicities.Add(data);
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

        public async override Task<ResultDto<EthnicityDto>> Update(EthnicityDto input)
        {
            var result = new ResultDto<EthnicityDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var ethnicity = await Context.Ethnicities.FindAsync(input.Id);
                    var data = ObjectMapper.Map<Ethnicity>(input);
                    data.CreatedDate = ethnicity.CreatedDate;
                    data.CreatedBy = ethnicity.CreatedBy;
                    data.ModifiedDate = DateTime.Now;
                    data.ModifiedBy = SessionExtensions.Login?.Id;
                    Context.Ethnicities.Update(data);
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

        public async override Task<ResultDto<EthnicityDto>> Delete(Guid id)
        {
            var result = new ResultDto<EthnicityDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var ethnicity = await Context.Ethnicities.FindAsync(id);
                    Context.Ethnicities.Remove(ethnicity);

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

        public async override Task<PagedResultDto<EthnicityDto>> GetAll(GetAllEthnicityInput input)
        {
            var result = new PagedResultDto<EthnicityDto>();
            try
            {
                var filter = Context.Ethnicities.AsQueryable()
                    .WhereIf(!string.IsNullOrEmpty(input.EthnicityCodeFilter), x => x.EthnicityCode == input.EthnicityCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.EthnicityNameFilter), x => x.EthnicityName == input.EthnicityNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.OrderBy(s => s.SortOrder).PageBy(input);

                result.TotalCount = await filter.CountAsync();
                result.Items = ObjectMapper.Map<IList<EthnicityDto>>(paged.ToList());
                result.IsSuccessed = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async override Task<ResultDto<EthnicityDto>> GetById(Guid id)
        {
            var result = new ResultDto<EthnicityDto>();
            try
            {
                var ethnicity = await Context.Ethnicities.FindAsync(id);
                result.Item = ObjectMapper.Map<EthnicityDto>(ethnicity);
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
