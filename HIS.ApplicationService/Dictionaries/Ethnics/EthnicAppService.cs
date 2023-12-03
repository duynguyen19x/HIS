using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Application.Core.Services.Dto;
using HIS.Core.Linq;
using HIS.Dtos.Dictionaries.Ethnics;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Dictionaries.Ethnics
{
    public class EthnicAppService : BaseCrudAppService<EthnicDto, Guid, GetAllEthnicInputDto>, IEthnicAppService
    {
        public EthnicAppService(HISDbContext context, IMapper mapper) 
            : base(context, mapper)
        {
        }

        public async override Task<ResultDto<EthnicDto>> Create(EthnicDto input)
        {
            var result = new ResultDto<EthnicDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = ObjectMapper.Map<Ethnic>(input);
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

        public async override Task<ResultDto<EthnicDto>> Update(EthnicDto input)
        {
            var result = new ResultDto<EthnicDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var ethnicity = await Context.Ethnicities.FindAsync(input.Id);
                    var data = ObjectMapper.Map<Ethnic>(input);
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

        public async override Task<ResultDto<EthnicDto>> Delete(Guid id)
        {
            var result = new ResultDto<EthnicDto>();
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

        public async override Task<PagedResultDto<EthnicDto>> GetAll(GetAllEthnicInputDto input)
        {
            var result = new PagedResultDto<EthnicDto>();
            try
            {
                var filter = Context.Ethnicities.AsQueryable()
                    .WhereIf(!string.IsNullOrEmpty(input.EthnicCodeFilter), x => x.EthnicCode == input.EthnicCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.EthnicNameFilter), x => x.EthnicName == input.EthnicNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.OrderBy(s => s.SortOrder).PageBy(input);

                result.TotalCount = await filter.CountAsync();
                result.Items = ObjectMapper.Map<IList<EthnicDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async override Task<ResultDto<EthnicDto>> GetById(Guid id)
        {
            var result = new ResultDto<EthnicDto>();
            try
            {
                var ethnicity = await Context.Ethnicities.FindAsync(id);
                result.Item = ObjectMapper.Map<EthnicDto>(ethnicity);
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
