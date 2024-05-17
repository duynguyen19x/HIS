using HIS.Dtos.Dictionaries.Ward;
using HIS.EntityFrameworkCore.Entities;
using Microsoft.EntityFrameworkCore;
using HIS.Core.Application.Services.Dto;
using HIS.Core.Extensions;
using HIS.Core.Domain.Repositories;
using HIS.Core.Application.Services;
using System.Transactions;

namespace HIS.ApplicationService.Dictionaries.Wards
{
    public class WardAppService : BaseAppService, IWardAppService
    {
        private readonly IRepository<Province, Guid> _provinceRepository;
        private readonly IRepository<District, Guid> _districtRepository;
        private readonly IRepository<Ward, Guid> _wardRepository;

        public WardAppService(
            IRepository<Province, Guid> provinceRepository,
            IRepository<District, Guid> districtRepository,
            IRepository<Ward, Guid> wardRepository)
        {
            _provinceRepository = provinceRepository;
            _districtRepository = districtRepository;
           _wardRepository = wardRepository;
        }

        public virtual async Task<PagedResultDto<WardDto>> GetAll(GetAllWardInput input)
        {
            var result = new PagedResultDto<WardDto>();
            try
            {
                var filter = _wardRepository.GetAll()
                    .WhereIf(!string.IsNullOrEmpty(input.CodeFilter), x => x.Code == input.CodeFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.NameFilter), x => x.Name == input.NameFilter)
                    .WhereIf(!string.IsNullOrEmpty(input.SearchCodeFilter), x => x.SearchCode == input.SearchCodeFilter)
                    .WhereIf(input.DistrictFilter != null, x => x.DistrictId == input.DistrictFilter)
                    .WhereIf(input.InactiveFilter != null, x => x.Inactive == input.InactiveFilter);

                if (Check.IsNullOrDefault(input.Sorting))
                    input.Sorting = "Code";

                filter = filter.ApplySortingAndPaging(input);

                var paged = from o in filter
                            join o1 in _districtRepository.GetAll() on o.DistrictId equals o1.Id
                            join o2 in _provinceRepository.GetAll() on o1.ProvinceId equals o2.Id
                            select new WardDto()
                            {
                                Id = o.Id,
                                Code = o.Code,
                                Name = o.Name,
                                SearchCode = o.SearchCode,
                                Description = o.Description,
                                Inactive = o.Inactive,
                                DistrictId = o1.Id,
                                DistrictCode = o1.Code,
                                DistrictName = o1.Name,
                                ProvinceId = o2.Id,
                                ProvinceCode = o1.Code,
                                ProvinceName = o2.Name
                            };

                result.TotalCount = await filter.CountAsync();
                result.Result = ObjectMapper.Map<IList<WardDto>>(paged.ToList());
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }

            return result;
        }

        public virtual async Task<ResultDto<WardDto>> GetById(Guid id)
        {
            var result = new ResultDto<WardDto>();
            try
            {
                var entity = await _wardRepository.GetAsync(id);

                result.Result = ObjectMapper.Map<WardDto>(entity);
                result.IsSucceeded = true;
            }
            catch (Exception ex)
            {
                result.Exception(ex);
            }
            return result;
        }

        public virtual async Task<ResultDto<WardDto>> CreateOrEdit(WardDto input)
        {
            if (Check.IsNullOrDefault(input.Id))
            {
                return await Create(input);
            }
            else
            {
                return await Update(input);
            }
        }

        public virtual async Task<ResultDto<WardDto>> Create(WardDto input)
        {
            var result = new ResultDto<WardDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    input.Id = Guid.NewGuid();
                    var entity = ObjectMapper.Map<Ward>(input);

                    await _wardRepository.InsertAsync(entity);

                    await unitOfWork.CompleteAsync();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<WardDto>> Update(WardDto input)
        {
            var result = new ResultDto<WardDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = await _wardRepository.GetAsync(input.Id.GetValueOrDefault());

                    ObjectMapper.Map(input, entity);

                    await unitOfWork.CompleteAsync();
                    result.Success(input);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

        public virtual async Task<ResultDto<WardDto>> Delete(Guid id)
        {
            var result = new ResultDto<WardDto>();
            using (var unitOfWork = UnitOfWorkManager.Begin(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    var entity = _wardRepository.Get(id);

                    await _wardRepository.DeleteAsync(entity);

                    unitOfWork.Complete();
                    result.Success(null);
                }
                catch (Exception ex)
                {
                    result.Exception(ex);
                }
            }
            return result;
        }

    }
}
