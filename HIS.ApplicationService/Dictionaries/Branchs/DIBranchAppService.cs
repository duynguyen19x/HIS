using AutoMapper;
using HIS.Application.Core.Services;
using HIS.Core.Services.Dto;
using HIS.Core.Domain.Repositories;
using HIS.Core.Domain.Uow;
using HIS.Core.Linq.Extensions;
using HIS.Dtos.Dictionaries.Branchs;
using HIS.EntityFrameworkCore;
using HIS.EntityFrameworkCore.Entities.Dictionaries;
using HIS.Utilities.Sections;
using Microsoft.EntityFrameworkCore;

namespace HIS.ApplicationService.Dictionaries.Branchs
{
    public class DIBranchAppService : BaseCrudAppService<BranchDto, Guid, GetAllBranchInput>, IDIBranchAppService
    {
        private readonly IRepository<Branch, Guid> _diBranchRepository;

        public DIBranchAppService(HISDbContext context, IMapper mapper,
            IRepository<Branch, Guid> diBranchRepository) 
            : base(context, mapper)
        {
            _diBranchRepository = diBranchRepository;
        }

        public async override Task<ResultDto<BranchDto>> Create(BranchDto input)
        {
            var result = new ResultDto<BranchDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var data = ObjectMapper.Map<Branch>(input);
                    data.CreatedDate = DateTime.Now;
                    data.CreatedBy = SessionExtensions.Login?.Id;

                    data.ProvinceId = null;
                    data.DistrictId = null;
                    data.WardId = null;

                    await _diBranchRepository.InsertAsync(data);

                    //Context.Branchs.Add(data);
                    //await SaveChangesAsync();
                    await transaction.CommitAsync();

                    result.IsSucceeded = true;
                    result.Result = input;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                    //transaction.Rollback();
                }
            }
            return result;
        }

        public async override Task<ResultDto<BranchDto>> Update(BranchDto input)
        {
            var result = new ResultDto<BranchDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var branch = Context.Branchs.AsNoTracking().FirstOrDefault(x => x.Id == input.Id);
                    var data = ObjectMapper.Map<Branch>(input);
                    data.CreatedDate = branch.CreatedDate;
                    data.CreatedBy = branch.CreatedBy;
                    data.ModifiedDate = DateTime.Now;
                    data.ModifiedBy = SessionExtensions.Login?.Id;
                    Context.Branchs.Update(data);
                    await SaveChangesAsync();
                    await transaction.CommitAsync();

                    result.IsSucceeded = true;
                    result.Result = input;
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public async override Task<ResultDto<BranchDto>> Delete(Guid id)
        {
            var result = new ResultDto<BranchDto>();
            using (var transaction = BeginTransaction())
            {
                try
                {
                    var branch = await Context.Branchs.FindAsync(id);
                    Context.Branchs.Remove(branch);

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

        public async override Task<PagedResultDto<BranchDto>> GetAll(GetAllBranchInput input)
        {
            var result = new PagedResultDto<BranchDto>();
            try
            {
                var filter = Context.Branchs.AsQueryable()
                    .WhereIf(!string.IsNullOrEmpty(input.BranchCodeFilter), x => x.Code == input.BranchCodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.BranchNameFilter), x => x.Name == input.BranchNameFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                var paged = filter.OrderBy(s => s.SortOrder).ThenBy(t => t.Code).ThenBy(t => t.Name).PageBy(input);

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<BranchDto>>(paged.ToList());
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public async override Task<ResultDto<BranchDto>> GetById(Guid id)
        {
            var result = new ResultDto<BranchDto>();
            try
            {
                var branch = await Context.Branchs.FindAsync(id);
                result.Result = ObjectMapper.Map<BranchDto>(branch);
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
